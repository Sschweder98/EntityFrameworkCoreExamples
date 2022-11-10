using System;
using System.Numerics;

namespace RandomProgrammToDoTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static int CountLetterAInSentence(String Sentence)
        {
            int Counter = 0;
            foreach (char Letter in Sentence)
            {
                if (Letter == 'A' || Letter == 'a')
                    Counter++;
            }
            return Counter;
        }

        static Boolean IsLetterBInSentence(String Sentence)
        {
            Boolean FoundLetterB = false;
            foreach (char Letter in Sentence)
            {
                if (Letter == 'B' || Letter == 'b')
                {
                    FoundLetterB = true;
                    break;
                }
            }
            return FoundLetterB;
        }
    }
}