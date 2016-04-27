using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FrameworkFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            #region old
            //string text = "a\t\nbbbbbbbbbbbb\t   aafaf\t";
            //Console.WriteLine(text);
            ////trim whitespaces
            //foreach(char c in text) if(!char.IsWhiteSpace(c)) Console.Write(c);
            //Console.WriteLine();
            //foreach(char c in text.Where(char.IsLower)) Console.Write(c);
            //Console.WriteLine("\n"+new string('*',20));
            //Console.WriteLine("Name={0,-20} Credit Limit={1,15:C}","Marek",123455.24);
            #endregion
            #region String vs StringBuilder
            //Stopwatch watch = new Stopwatch();
            //string s = "";
            //StringBuilder sb = new StringBuilder();
            ////measurement for string
            //watch.Start();
            //for (int i = 0; i < 150000; i++)
            //{
            //    s += i;
            //    Console.WriteLine(i);
            //}
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);
            //Console.WriteLine(watch.ElapsedTicks);
            //watch.Reset();
            ////measurement for string builder
            //watch.Start();
            //for (int i = 0; i < 150000; i++)
            //{
            //    sb.Append(i);
            //}
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);
            //Console.WriteLine(watch.ElapsedTicks);
            //watch.Reset();
            #endregion
            #region Encoding
            //byte[] utf8Bytes = Encoding.UTF8.GetBytes("0123456789");
            //byte[] utf16Bytes = Encoding.Unicode.GetBytes("0123456789");
            //byte[] utf32Bytes = Encoding.UTF32.GetBytes("0123456789");
            //Console.WriteLine("{0} {1} {2}", utf8Bytes.Length, utf16Bytes.Length, utf32Bytes.Length);
            //foreach(EncodingInfo info in Encoding.GetEncodings()) Console.WriteLine(info.Name); 
            #endregion

            Guid g = Guid.NewGuid();
            Console.WriteLine(g);



            Console.ReadLine();
        }
    }
}
