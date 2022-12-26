using System;

namespace Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write(" ЗАДАЧА 1.Прибавить 10 к введенному числу");
           Console.WriteLine("\nВведите число и нажмите enter");
           double a = Convert.ToDouble(Console.ReadLine());
          

           double sum = a + 10;
      
           Console.WriteLine($Число равно - {sum}"); */

            Console.WriteLine("Задача №2");
            Console.WriteLine("Введите строку: ");
            Class1.txt = Console.ReadLine();
            Console.WriteLine("Введите индекс: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Class1.remov(k);




           


        }
    }
}
