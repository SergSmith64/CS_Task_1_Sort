using System;

namespace Task_1_Sort
{
    class Program
    {
        // Инициализация массива
        int[] a = { 73, 45, 88, 13, 55, 49, 11, 82 };
        int f1;

        // 2 мая
        // ПУСТОЙ МАССИВ
        // int[] a = {};

        // ДОБАВИЛ ПРОВЕРКУ НА ПУСТОЙ МАССИВ
        //if(a.Length == 0) Console.WriteLine("Массив пуст");

        // или такую проверку:
        // if (a == null || a.Length == 0) 
        //{ 
        //Console.WriteLine("Ваш массив пуст!");
        //}


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
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }

        public void checkInput()
        {
            // ВВЕДЕМ ЗНАЧЕНИЕ ДЛЯ ПОИСКА ПО МАССИВУ
            Console.WriteLine("\nВведите число = ");

            // -- старый вариант --
            // int f1 = Convert.ToInt32(Console.ReadLine());

            

            // -- новый вариант --
            string stroka = Console.ReadLine();
            // int f1;

            // rezult = true ЕСЛИ ВВЕЛИ ЧИСЛО и false ЕСЛИ НЕ ЧИСЛО
            bool rezult = int.TryParse(stroka, out f1);

            // ПОТОМ УБРАТЬ__________________________________
            Console.WriteLine("Значение f1 = " + f1);
            Console.WriteLine("Значение stroka = " + stroka);


            if (rezult)
            {
                Console.WriteLine("Значение для поиска ВВЕДЕНО КОРРЕКТНО = " + f1);
                findElem();
            }
            else
            {
                Console.WriteLine("НЕКОРРЕКТНЫЙ ВВОД ДАННЫХ");
                // ПРОБУЮ РЕКУРСИЮ
                checkInput();
            }
        }

        public void findElem()
        {
            for (int i = 0; i < a.Length; i++)
            {
                // ПОТОМ УБРАТЬ__________________________________
                Console.WriteLine("Значение i = " + i);
                Console.WriteLine("Значение a.Length = " + a.Length);
                Console.WriteLine("Значение a[] = " + a[i]);
                Console.WriteLine("Значение f1 = " + f1);


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



        // 2. Не обработан случай пустого массива.
        // Сама функция не выведен ничего в случае пустого массива, так как цикла перебора не будет в принципе:
        // _______________________ a.Length
        // Предлагаемое решение:
        //- универсализировать алгоритм;
        // Рекомендации.
        // - разделить логику и визуал (пусть это лишь консольный вывод).
        // Не завязывать функции с логикой (прим. findElem())и конкретный вывод.
        // Например, можно возвращать bool;


        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ-1:");
            Console.WriteLine("\nДан массив целых чисел из 8 элементов: ");

            Program sort = new Program();
            sort.PrintArray();
            sort.bubbleSort();

            Console.WriteLine("\n\nОТСОРТИРОВАННЫЙ МАССИВ :");
            sort.PrintArray();

            Console.WriteLine($"\n\nЗАДАНИЕ-2: \n\nПоиск заданного значения в отсортированном массиве.");

            sort.checkInput();

            

            Console.ReadKey();

        }
    }
}
