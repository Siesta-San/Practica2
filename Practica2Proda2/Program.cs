namespace Practica2Proda2
{
    internal class Program
    {
        static void Main(string[] args)
        {   // 9 Вывести на экран число с точностью до сотых (Math.Round(с, n), где с – округляемое число, n – число знаков после запятой).
            double number = 12.1323123;
            Console.WriteLine($"Округления числа {number} с точностью до сотых: ");
            Console.WriteLine($"{Math.Round(number,2)}");
            // 10 Вывести на экран число e(Math.E) с точностью до десятых.
            Console.WriteLine($"Округления числа {Math.E} с точностью до десятых: ");
            Console.WriteLine($"{Math.Round(Math.E, 1)}");
            // 11 Составить программу вывода на экран числа, вводимого с клавиатуры.Выводимому числу должно предшествовать сообщение «Вы ввели число».
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число - {num}");
            // 12 Составить программу вывода на экран числа, вводимого с клавиатуры.После выводимого числа должно следовать
            // сообщение» — вот какое число Вы ввели».
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} — вот какое число Вы ввели ");
            // 13 Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.
            Console.WriteLine("1 13 49");
        }
    }
}
