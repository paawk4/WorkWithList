using System;
using System.Collections.Generic;

namespace WorkWithList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Яблоко", "Груша", "Банан" };

            while (true)
            {
                OutPutList(list); // вывод листа

                Console.WriteLine("Что хотите сделать?\n" +
                    "1. Отсортировать по алфавиту\n" +
                    "2. Добавить элемент");
                int index = int.Parse(Console.ReadLine());

                switch (index)
                {
                    case 1:
                        list.Sort(); // сортировка
                        break;
                    case 2:
                        list.Add(Console.ReadLine()); // добавление элемента
                        break;
                    default:
                        Console.WriteLine("Введите другие значения");
                        break;
                }
            }
        }

        private static void OutPutList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item); ;
            }
        }
    }
}
