namespace Practica2Proda1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 7 Создайте 2 числа int a = 3; double b = 2.6; Запишите сумму этих чисел в одну из переменных путём
            // неявного преобразования данных.
            Console.WriteLine("7 номер");
            int a = 3;
            double b = 2.6;
            b = a + b;
            Console.WriteLine(b);
            // 8 Введите целое число a с клавиатуры и выведите квадрат этого числа.
            Console.WriteLine("8 номер");
            Console.WriteLine("Введите число для возведения в квадрат");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num * num);
        }
    }
}
