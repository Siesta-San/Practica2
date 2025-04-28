namespace practica2Proda4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 17 Известны объем и масса тела.Определить плотность
            // материала этого тела.m = p * V, где m – масса, p – плотность, V – объём.
            Console.WriteLine("Введите плотность обьекта");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите обьем обьекта");
            int v = int.Parse(Console.ReadLine());
            int massa = v * p;
            Console.WriteLine("Масса обьекта" +  massa);

            // 18 Составить программу решения линейного уравнения ax+b = 0(a ≠ 0).a и b ввести с клавиатуры.
            Console.WriteLine("18 задание - решение уравнения ax + b = 0");
            Console.WriteLine("Введите коэффициент a (a ≠ 0):");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициент b:");
            double b = double.Parse(Console.ReadLine());

            double x = -b / a;
            Console.WriteLine($"Решение уравнения: x = {x}");

            

        }
    }
}
