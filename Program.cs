using System;
using System.Collections.Generic;

namespace Odnimer_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявляем и инициализируем исходный массив
            int[] sourceArray = new int[] { 2, 4, 7, 9, 12, 15, 18 };

            // Создаем новый список для нечетных чисел
            List<int> oddNumbers = new List<int>();

            // Проходим по каждому элементу исходного массива
            foreach (int number in sourceArray)
            {
                // Если число нечетное, добавляем его в список
                if (number % 2 != 0)
                {
                    oddNumbers.Add(number);
                }
            }

            // Сортируем список по убыванию
            oddNumbers.Sort((a, b) => b.CompareTo(a));

            // Преобразуем список в массив
            int[] resultArray = oddNumbers.ToArray();

            // Выводим результат
            foreach (int number in resultArray)
            {
                Console.Write(number + " ");
            }
        }
    }
}
