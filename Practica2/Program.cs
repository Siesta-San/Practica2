using System;

namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 номер ");
            Random rnd = new Random();

            Console.Write("Введите минимальное значение (a): ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Введите максимальное значение (b): ");
            int num2 = int.Parse(Console.ReadLine());

            // Генерируем случайное число в диапазоне от a до b
            int randomNumber = rnd.Next(num1, num2);
            
            Console.WriteLine($"Случайное число между {num1} и {num2}: {randomNumber}");


            Console.WriteLine("6 номер");
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5 + (double)a + (double)b;
            Console.WriteLine(c);

        }
    }
}
