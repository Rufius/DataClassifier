using System;

namespace DataClassifier
{
    internal class Program
    {
        private static int counterA = 0; // this counter stores the position of the current character match in the potential xxx sequence starting from 1
        private static int counterB = 0; // this counter stores the position of the current character match in the potential xyx sequence starting from 1

        static void Main(string[] args)
        {
            int i = 0;

            while ((i = Console.Read()) != -1)
            {
                char c = Convert.ToChar(i);
                switch (c)
                {
                    case 'x':
                        ProcessX();
                        break;
                    case 'y':
                        ProcessY();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine($"Error: Wrong input - {c}");
                        return;
                }

                if (counterA == 3)
                {
                    Console.Write('A');
                    counterA = counterB = 0;
                }
                else if (counterB == 3)
                {
                    Console.Write('B');
                    counterA = counterB = 0;
                }
            }
        }

        private static void ProcessX()
        {
            if (counterA == 0 && counterB == 0) // first match in potential xxx or xyx
            {
                counterA++;
                counterB++;
            }
            else if (counterA > 0) // second or third match in xxx
            {
                counterA++;
                counterB = counterA == 2 ? 1 : 0; // for second match in potential xxx
            }
            else if(counterB == 2) // third x match in xyx
            {
                counterA = 0;
                counterB++;
            }
            else // in any other case reset counters
            {
                counterA = counterB = 0;
            }
        }

        private static void ProcessY()
        {
            if (counterB == 1) // y match in potential xxx or xyx sequence
            {
                counterA = 0;
                counterB++;
            }
            else // in other case reset counters
            {
                counterA = counterB = 0;
            }
        }
    }
}
