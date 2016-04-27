using System;
using System.Runtime.CompilerServices;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args) { 
            Foo foo = new Foo();
            foo.PropertyChanged += Foo_PropertyChanged;
            foo.CustomerName = "a";
            foo.CustomerName = "b";
            Console.ReadLine();
        }

        private static void Foo_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("Achtung!");
        }

        static void Foo([CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null,
            [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine(memberName);
            Console.WriteLine(filePath);
            Console.WriteLine(lineNumber);
        }
    }
}
