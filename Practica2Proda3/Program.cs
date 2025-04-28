namespace Practica2Proda3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14 Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.
            Console.WriteLine("7  15  100");

            // 15
            Console.WriteLine("15 задание");
            float z;
            int a = 1, b = 2, c = 4;
            const int m = 3;
            z = (a + b + c) / m;
            Console.WriteLine(z); // результат 2 

            // 16
            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());
            int  sredarifmethic = (num1 + num2) / 2;
            Console.WriteLine("Среднее арифметическое: " + sredarifmethic);

            int proizvedenie = num1 * num2;
            double sredgeom = Math.Sqrt(proizvedenie);
            Console.WriteLine("Среднее геометрическое: " + sredgeom);
        }
    }
}
