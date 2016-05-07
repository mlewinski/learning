using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostics
{
    class Program
    {
        static readonly IList<int> testList = null;
        static void Main(string[] args)
        {
            #region Trace
            //Trace.Listeners.Clear();
            //TextWriterTraceListener tl = new TextWriterTraceListener(Console.Out);
            //tl.TraceOutputOptions = TraceOptions.Callstack | TraceOptions.DateTime;
            //Trace.TraceWarning("alert orange"); 
            #endregion

            Console.WriteLine(AddIfNotPresent(testList, 5));
            Console.ReadLine();
        }

        static bool AddIfNotPresent<T>(IList<T> list, T item)
        {
            Contract.Requires(list!=null);
            Contract.Requires(!list.IsReadOnly);
            Contract.Ensures(list.Contains(item));
            if (list.Contains(item)) return false;
            list.Add(item);
            return true;
        }
    }
}
