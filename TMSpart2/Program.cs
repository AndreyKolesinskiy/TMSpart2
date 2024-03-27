using System;
using System.Collections.Generic;
using System.Linq;

namespace TMSpart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AdditionalExercisesLesson16.CountWords("It is a nice day but yesterday it rained all day."));
            AdditionalExercisesLesson16.PrintFizzBuzzNumbers(1, 100);
        }

        // 1. Извлечение положительных двузначных чисел из последовательности
        static void Exercise1()
        {
            string initialString = "11, -21, 64, 59, 11, 0, -7, 53, -31, 1";
            string initialStringWithoutSpaces = initialString.Replace(" ", "");
            List<int> listOfNumbers = initialStringWithoutSpaces.Split(',').Select(int.Parse).ToList();

            listOfNumbers.Sort();
            foreach (int number in listOfNumbers)
            {
                if (number >= 10) { Console.WriteLine(number); }
            }
        }

        // 2. Выборка чётных чисел из последовательности
        static void Exercise2()
        {
            string initialString = "11, 23, 60, 57, 62, 17, 42, 34, 123";
            string initialStringWithoutSpaces = initialString.Replace(" ", "");
            List<int> listOfNumbers = initialStringWithoutSpaces.Split(',').Select(int.Parse).ToList();

            foreach (int number in listOfNumbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        // 3. Вывод слова в обратном порядке
        static void Exercise3()
        {
            string initialString = "automation";
            Console.WriteLine(initialString.Reverse().ToArray());
        }

        // 4. Изменение первой буквы в именах
        static void Exercise4()
        {
            string initialString = "Alexa, Kirill, Jonas, Alina, Andrey, Danila, Nick, Amer, Chastity, Khristina, Amelia";
            string initialStringWithoutSpaces = initialString.Replace(" ", "");
            List<string> listOfNames = initialStringWithoutSpaces.Split(',').ToList();
            List<string> listOfNamesChanged = new List<string>();
            foreach (string name in listOfNames)
            {
                string checkedName = name.StartsWith("A") ? name.Replace("A", "I") : name;
                listOfNamesChanged.Add(checkedName);
            }
            foreach (string name in listOfNamesChanged) { Console.Write(name + " "); }
        }

        // 5. Объединение списков имен и фильтрация по предпоследней букве
        static void Exercise5()
        {
            string initialString1 = "Igor, Vasya, Alex";
            string initialString2 = "Nikita, Yura, Sergey";
            List<string> list1 = initialString1.Replace(" ", "").Split(',').ToList();
            List<string> list2 = initialString2.Replace(" ", "").Split(',').ToList();
            list1.AddRange(list2);
            list1.RemoveAll(a => a.EndsWith("a"));
            foreach (string s in list1)
            {
                Console.WriteLine(s);
            }
        }

        // 6. Сортировка имен по длине
        static void Exercise6()
        {
            string initialString = "Brenda, Kristina, Anna, Nik, Hugo, Alice, Selena";
            List<string> listOfNames = initialString.Replace(" ", "").Split(',').ToList();
            var listOfNamesSorted = listOfNames.OrderBy(s => s.Length).ToList();
            foreach (string s in listOfNamesSorted) { Console.WriteLine(s); }
        }
    }
}
