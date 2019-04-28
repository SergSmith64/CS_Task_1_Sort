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

        public void findElem()
        { 
        	// ОПРЕДЕЛЯЕМ ЗАДАННОЕ ЗНАЧЕНИЕ ДЛЯ ПОИСКА ПО МАССИВУ
        	Console.WriteLine("Введите число = ");
        	int f1 = Convert.ToInt32(Console.ReadLine());
        	
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
            	if (i == a.Length-1) 
            	{ 
            		Console.WriteLine($"введенного значения {f1} в массиве НЕ НАЙДЕНО");
            	}
            }
        }

        static void Main(string[] args)
        {
        	Console.WriteLine("ЗАДАНИЕ-1:");
            Console.WriteLine("\nДан массив целых чисел из 8 элементов: ");

            Program sort = new Program();
            sort.PrintArray();
            sort.bubbleSort();

            Console.WriteLine("\nОТСОРТИРОВАННЫЙ МАССИВ :");
            sort.PrintArray();

            Console.WriteLine();
            Console.WriteLine($"\nЗАДАНИЕ-2: \nПоиск заданного значения в отсортированном массиве.");
            Console.WriteLine();

            sort.findElem();

            Console.ReadKey();

        }
    }
}
