namespace Practica2proda8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 25 Ввести с клавиатуры четырёхзначное число.Найти сумму и произведение его цифр. Для нахождения цифр числа использовать операции деления(/) и остатка от деления(%).
            int num = 1234;
            double chislo1 = num / 1000;
            double chislo2 = ((num % 1000) / 100);
            double chislo3 = (num % 100) / 10;
            double chislo4 = num % 10;
            Console.WriteLine(chislo1);
            Console.WriteLine(chislo2);
            Console.WriteLine(chislo3);
            Console.WriteLine(chislo4);
            Console.WriteLine("Сумма цифр числа:");
            Console.WriteLine(chislo1 + chislo2 + chislo3 + chislo4);
            Console.WriteLine("Произведение цифр числа:");
            Console.WriteLine(chislo1 * chislo2 * chislo3 * chislo4);
        }
    }
}
