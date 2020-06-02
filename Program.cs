using System;
using System.Collections.Generic;
using static System.Console;

namespace Fibonacci
{

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(string.Concat(new string('#', 50), "##"));
            WriteLine(string.Concat(" F i b o n a c c i ".PadLeft(50, '#'), "##"));
            WriteLine(string.Concat(new string('#', 50), "##"));

            if (args.Length > 0 && int.TryParse(args[0], out int param))
            {
                int[] fibonacciSequence = DoFibonacci(param);
                int leftCollumn = fibonacciSequence.Length.ToString().ToCharArray().Length;

                for (int i = 0; i < fibonacciSequence.Length; i++)
                {
                    if (i == 0)
                        WriteLine(string.Concat("##".PadRight(leftCollumn + 8), "##", new string(' ', 50 - leftCollumn - 8 - 2), "##"));
                    WriteLine(string.Concat($"##  {i} ".PadRight(leftCollumn + 5), "th ##", $"{ fibonacciSequence[i]}  ".PadLeft(50 - leftCollumn - 10), "##"));
                    
                    if (i == fibonacciSequence.Length-1) { }
                    else
                        WriteLine(string.Concat("##".PadRight(leftCollumn + 8), "##", new string('-', 50 - leftCollumn - 8 - 2), "##"));
                }
                WriteLine(string.Concat("##".PadRight(leftCollumn + 8), "##", new string(' ', 50 - 8 - leftCollumn - 2), "##"));
            }
            else
            {
                WriteLine(string.Concat("#", new string(' ', 50), "#"));
                WriteLine(string.Concat("#", "You did not input parameter to work with!     ".PadLeft(50), "#"));
                WriteLine(string.Concat("#", new string(' ', 50), "#"));
            }

            WriteLine(string.Concat(new string('#', 50), "##"));
            WriteLine(string.Concat(" End of program. ".PadLeft(50, '#'), "##"));
            WriteLine(string.Concat(new string('#', 50), "##"));

        }

        private static int[] DoFibonacci(int param)
        {
            int[] ret = new int[param];
            ret[0] = 0;
            ret[1] = 1;
            for (int i = 2; i < param; i++)
            {
                ret[i] = (ret[i - 1]) + (ret[i - 2]);
            }


            return ret;
        }
    }
}
