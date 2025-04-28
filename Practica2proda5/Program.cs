namespace Practica2proda5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 19 Дано уравнение ax2-bx+c=e. Найти х. Math.Pow(x, y), где x – число возводимое в степень, y – показатель степени.
            Console.WriteLine("19 задание - решение уравнения ax² - bx + c = e");
            Console.WriteLine("Введите коэффициент a:");
            double a19 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициент b:");
            double b19 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициент c:");
            double c19 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение e:");
            double e19 = double.Parse(Console.ReadLine());

            // Приводим уравнение к стандартному виду ax² + bx + c = 0
            double A = a19;
            double B = -b19;
            double C = c19 - e19;

            // Вычисляем дискриминант
            double D = Math.Pow(B, 2) - 4 * A * C;

            if (D > 0)
            {
                double x1 = (-B + Math.Sqrt(D)) / (2 * A);
                double x2 = (-B - Math.Sqrt(D)) / (2 * A);
                Console.WriteLine($"Уравнение имеет два решения: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -B / (2 * A);
                Console.WriteLine($"Уравнение имеет одно решение: x = {x}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных решений");
            }


            // 20 Даны катеты(a, b) прямоугольного треугольника. Найти его гипотенузу(c).a2 + b2 = c2
            Console.WriteLine("Введите катет a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите катет b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Гпотенуза c:");
            Console.WriteLine(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
