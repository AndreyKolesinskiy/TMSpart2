using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TMSpart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercize1();
        }

        static void Exercize1()
        {
            string initialString = "11, -21, 64, 59, 11, 0, -7, 53, -31, 1";
            string initialStringWithoutSpaces = initialString.Replace(" ", "");

            Console.WriteLine(initialStringWithoutSpaces);
            List<int> listOfNumbers = initialStringWithoutSpaces.Split(',').Select(int.Parse).ToList();
          
            listOfNumbers.Sort();
            foreach (int number in listOfNumbers)
            {
                if (number >= 10) { Console.WriteLine(number); }

            }
        }
    }
}
