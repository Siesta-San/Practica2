namespace _21_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 21 Найти площадь кольца(S) по заданным внешнему(R) и внутреннему(r) радиусам.S = π(R2 – r2)
            Console.WriteLine("Введите внешний радиус R:");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите внутренний радиус r:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь кольца S:");
            Console.WriteLine((Math.Pow(R,2) - Math.Pow(r,2)) * Math.PI);

            // 22 Даны катеты прямоугольного треугольника. Найти его периметр(P = a + b + c).
            Console.WriteLine("Введите число a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c:");
            Console.WriteLine(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Периметр равен:");
            Console.WriteLine(a + b + (Math.Pow(a, 2) + Math.Pow(b, 2)));

            // 23 Даны два числа.Найти среднее арифметическое и среднее геометрическое их модулей. Math.Abs(n), где n – число вычисляемого модуля.
            int chislo1 = 225;
            int chislo2 = 75;
            Console.WriteLine("Среднее арифметическое:");
            Console.WriteLine((Math.Abs(a) + Math.Abs(b)) / 2);
            Console.WriteLine("Среднее геометрическое:");
            Console.WriteLine(Math.Sqrt(Math.Abs(a) + Math.Abs(b)));


        }
    }
}
