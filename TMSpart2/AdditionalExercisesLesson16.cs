using System;
using System.Linq;

namespace TMSpart2
{
    public static class AdditionalExercisesLesson16
    {
        public static int CountWords(string sentence)
        {
            try
            {
                var counter = sentence.Split(' ').Where(x=>x !="").Count();
                return counter;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input" + ex.Message);
                return 0;
            }
        }

        public static void PrintFizzBuzzNumbers(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

