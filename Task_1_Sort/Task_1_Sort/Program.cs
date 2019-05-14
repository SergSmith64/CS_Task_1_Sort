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
        readonly int[] a = { 73, 45, 88, 13, 55, 49, 11, 82 };
        int f1;


        // ВЫВОД МАССИВА В КОНСОЛЬ
        public void PrintArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "  ");
            }
        }

        // СОРТИРОВКА ПУЗЫРЬКОМ
        public void BubbleSort()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }

        public void CheckInput()
        {
            // ВВЕДЕМ ЗНАЧЕНИЕ ДЛЯ ПОИСКА ПО МАССИВУ
            Console.Write("\nВведите число = ");

            // -- старый вариант --
            // int f1 = Convert.ToInt32(Console.ReadLine());


            // -- новый вариант --
            string stroka = Console.ReadLine();

            // rezult = true ЕСЛИ ВВЕЛИ ЧИСЛО и false ЕСЛИ НЕ ЧИСЛО
            bool rezult = int.TryParse(stroka, out f1);


            if (rezult)
            {
                Console.WriteLine("Значение для поиска ВВЕДЕНО КОРРЕКТНО = " + f1);
                FindElem();
            }
            else
            {
                Console.WriteLine("НЕКОРРЕКТНЫЙ ВВОД ДАННЫХ");
                // ВЫЗЫВАЮ РЕКУРСИЮ
                CheckInput();
            }
        }

        public void FindElem()
        {
            // ДОБАВИЛ ПРОВЕРКУ ПУСТОГО МАССИВА
            if (a.Length != 0)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != f1)
                    {
                        //Console.WriteLine($"введенного значения {a[i]} в массиве НЕ НАЙДЕНО");
                    }
                    else
                    {
                        Console.WriteLine($"введенное значение {a[i]} присутствует в массиве!");
                        break;
                    }
                    if (i == a.Length - 1)
                    {
                        Console.WriteLine($"введенного значения {f1} в массиве НЕ НАЙДЕНО");
                    }
                }
            }
            else
            {
                Console.WriteLine("Этот массив пуст");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ-1:");
            Console.WriteLine("\nДан массив целых чисел из 8 элементов: ");

            Program sort = new Program();
            sort.PrintArray();
            sort.BubbleSort();

            Console.WriteLine("\n\nОТСОРТИРОВАННЫЙ МАССИВ :");
            sort.PrintArray();

            Console.WriteLine($"\n\nЗАДАНИЕ-2: \n\nПоиск заданного значения в отсортированном массиве.");
            sort.CheckInput();

            Console.ReadKey();

        }
    }
}
