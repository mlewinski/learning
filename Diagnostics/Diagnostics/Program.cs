using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Diagnostics
{
    class Program
    {
        //static readonly IList<int> testList = null;
        static void Main(string[] args)
        {
            #region Trace

            //Trace.Listeners.Clear();
            //TextWriterTraceListener tl = new TextWriterTraceListener(Console.Out);
            //tl.TraceOutputOptions = TraceOptions.Callstack | TraceOptions.DateTime;
            //Trace.TraceWarning("alert orange");
            #endregion

            EventWaitHandle stopper = new ManualResetEvent(false);

            new Thread((() => Monitor("Processor", "% Processor Time", "_Total", 750, stopper))).Start();

            new Thread((() => Monitor("LogicalDisk", "% Idle Time", "C:", 2000, stopper))).Start();

            Console.WriteLine("Monitoring - press any key to quit");

            Console.ReadLine();
            stopper.Set();
            Console.Write("Stopped \n");
            Console.ReadLine();
        }

        static void Monitor(string category, string counter, string instance, int miliseconds, EventWaitHandle stopper)
        {
            if(!PerformanceCounterCategory.Exists(category)) throw new InvalidOperationException("Category does not exist");
            if(!PerformanceCounterCategory.CounterExists(counter, category)) throw new InvalidOperationException("Counter does not exist");
            if (instance == null) instance = "";
            if (instance != "" && !PerformanceCounterCategory.InstanceExists(instance, category))
                throw new InvalidOperationException("Instance does not exist");

            float lastValue = 0f;
            using (PerformanceCounter pc = new PerformanceCounter(category, counter, instance))
            {
                while (!stopper.WaitOne(miliseconds, false))
                {
                    float value = pc.NextValue();
                    if (value != lastValue)
                    {
                        Console.WriteLine("{0}.{1} - {2} : {3}",category, counter, instance, value);
                        lastValue = value;
                    }
                }
            }
        }

        //static bool AddIfNotPresent<T>(IList<T> list, T item)
        //{
        //    Contract.Requires(list!=null);
        //    Contract.Requires(!list.IsReadOnly);
        //    Contract.Ensures(list.Contains(item));
        //    if (list.Contains(item)) return false;
        //    list.Add(item);
        //    return true;
        //}
    }
}
