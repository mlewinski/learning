using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Grep
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Too few arguments! See --help ");
                return;
            }
            if (args.Contains("--help"))
            {
                Console.WriteLine("Simple Grep : ");
                Console.WriteLine("grep.exe pattern [options] --filelist [files]");
                Console.WriteLine("--invert : invert match ");
                Console.WriteLine("--begins : match only lines beginning with the pattern");
                Console.WriteLine("--case-ignore : ignore letters size");
                Console.WriteLine("--filelist : indicates beginning of file list");
                return;
            }
            string pattern = args[0];
            BitArray options = new BitArray(3);
            if (args.Contains("--invert")) options[0] = true;
            if (args.Contains("--begins")) options[1] = true;
            if (args.Contains("--case-ignore")) options[2] = true;
            int fileListBeginning = Array.IndexOf(args, "--filelist") + 1;
            for (int i = fileListBeginning; i < args.Length; i++)
            {
                try
                {
                    int lineNumber = 0;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Parsing file : {0}", args[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    using (StreamReader f = new StreamReader(args[i]))
                    {
                        string line = null;
                        while ((line = f.ReadLine()) != null)
                        {
                            lineNumber++;
                            if (options[2] == true)
                            {
                                line = line.ToUpper();
                                pattern = pattern.ToUpper();
                            }
                            if (options[0] == true)
                            {
                                if (line.Contains(pattern)) continue;
                                if (options[1] == true)
                                {
                                    if (!line.StartsWith(pattern))
                                    {
                                        PrintMatch(args[i], lineNumber);
                                    }
                                }
                                else
                                {
                                    PrintMatch(args[i], lineNumber);
                                }
                            }
                            else
                            {
                                if (line.Contains(pattern)) {
                                    PrintMatch(args[i], lineNumber);
                                }
                                else if (options[1] == true)
                                {
                                    if (line.StartsWith(pattern))
                                    {
                                        PrintMatch(args[i], lineNumber);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (IOException exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! \n {0}", exception.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.ReadLine();
        }

        private static void PrintMatch(string fileName, int lineNumber)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} : {1} ", fileName, lineNumber);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
