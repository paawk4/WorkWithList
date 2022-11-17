using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Яблоко", "Груша", "Банан" };

            while (true)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]); // вывод листа
                }

                Console.WriteLine("Что хотите сделать?\n" +
                    "1. Отсортировать по алфавиту\n" +
                    "2. Добавить элемент");
                int index = int.Parse(Console.ReadLine());

                if (index == 1)
                {
                    list.Sort(); // сортировка
                }
                else if (index == 2)
                {
                    list.Add(Console.ReadLine()); // добавление элемента
                }
                else
                {
                    Console.WriteLine("Введите другие значения");
                }
            }
            Console.WriteLine("Недостижимый код");
        }
    }
}
