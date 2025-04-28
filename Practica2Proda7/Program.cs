namespace Practica2Proda7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 24 Дано вещественное число а. Пользуясь только операцией умножения, получить:
            // а) a4 за две операции;
            // б) a6 за три операции;
            // в) a7 за четыре операции;
            // г) a8 за три операции;
            // д) a9 за четыре операции;
            // е) a10 за четыре операции.
            int originalA = int.Parse(Console.ReadLine()); 
            // а
            int a4 = originalA * originalA; 
            a4 = a4 * a4;                   
            Console.WriteLine($"а) {a4}");

            // б
            int a6 = originalA * originalA; 
            a6 = a6 * originalA;            
            a6 = a6 * a6 * a6;              
            Console.WriteLine($"б) {a6}");

            // в
            int a7 = originalA * originalA * originalA; 
            a7 = a7 * a7;                              
            a7 = a7 * originalA;                        
            Console.WriteLine($"в) {a7}");

            // г
            int a8 = originalA * originalA; 
            a8 = a8 * a8;                   
            a8 = a8 * a8;                
            Console.WriteLine($"г) {a8}");

            // д
            int a9 = originalA * originalA * originalA; 
            a9 = a9 * a9 * a9;                        
            Console.WriteLine($"д) {a9}");

            // е
            int a10 = originalA * originalA; 
            a10 = a10 * a10;                
            a10 = a10 * a10;                
            a10 = a10 * (originalA * originalA); 
            Console.WriteLine($"е) {a10}");
        }
    }
}
