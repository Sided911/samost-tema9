using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1.В массиве записана масса каждого из n предметов, загружаемых в автомобиль. 
            //Определить общую массу груза.
            //int n = 5;
            //int[] gruz = new int[n];
            //int totalgruz = 0;
            //gruz[0] = 200;
            //gruz[1] = 350;
            //gruz[2] = 425;
            //gruz[3] = 125;
            //gruz[4] = 525;
            //    for (int i = 0; i < n; i++)
            //    {
            //        totalgruz += gruz[i];
            //    }
            //    Console.WriteLine("Общая масса груза: " + totalgruz);
            //Console.Read();

            //задание 2. Известен рост каждого студента 212 группы. 
            //Найти средний рост студентов.
            //int[] rost = { 175, 180, 165, 170, 185, 190, 160, 170, 175, 180 };
            //int sum = 0;
            //for (int i = 0; i < rost.Length; i++)
            //{
            //    sum += rost[i];
            //}
            //double srdnrost = (double)sum / rost.Length;
            //Console.WriteLine("Средний рост студентов: " + srdnrost + " см");
            //Console.ReadKey();

            //задание 3. Определить количество отрицательных, положительных и нулевых элементов одномерного массива, 
            //заполненного случайным образом 15 целыми числами в интервале [-10; 10]. 
            //int[] array = new int[15];
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(-10, 11);
            //}
            //Console.WriteLine("Массив: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            //int otric = 0;
            //int polojitel = 0;
            //int nulevie = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < 0)
            //    {
            //        otric++;
            //    }
            //    else if (array[i] > 0)
            //    {
            //        polojitel++;
            //    }
            //    else
            //    {
            //        nulevie++;
            //    }
            //}
            //Console.WriteLine("Количество отрицательных элементов: " + otric);
            //Console.WriteLine("Количество положительных элементов: " + polojitel);
            //Console.WriteLine("Количество нулевых элементов: " + nulevie);
            //Console.ReadLine();

            //задание 4.Подсчитать количество четных элементов в одномерном массиве,
            //заполненном с использованием явной инициализации.
            int[] numbers = { 20, 55, 64, 82, 97, 18, 13, 15, 16, 22 };
            int evenCount = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
            }
            Console.WriteLine("Количество четных элементов: " + evenCount);
            Console.Read();
        }
    }
}
