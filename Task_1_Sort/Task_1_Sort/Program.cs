using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Sort
{
    class Program
    {
        // Инициализация массива
        int[] a = { 73, 45, 88, 13, 55, 49, 11, 82 };

        // ВЫВОД МАССИВА В КОНСОЛЬ
        public void PrintArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "  ");
            }
        }

        // СОРТИРОВКА ПУЗЫРЬКОМ
        public void bubbleSort()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a [i] > a [j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Дан массив целых чисел из 8 элементов: ");

            Program sort = new Program();
            sort.PrintArray();
            sort.bubbleSort();
            Console.WriteLine();
            Console.WriteLine("ОТСОРТИРОВАННЫЙ МАССИВ :");
            sort.PrintArray();
            Console.ReadKey();

        }
    }
}
