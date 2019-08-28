using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number: ");
            int? sayi01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int? sayi02 = Convert.ToInt32(Console.ReadLine());

            string message = (sayi01>sayi02) ? "First number > Second number" : "Second number > First number";

            Console.WriteLine(message + "\nPush enter for continue..");
            Console.ReadKey();


            Console.WriteLine("Give me a number: ");
            int? sayi03 = int.Parse(Console.ReadLine());

            string evenOrNot = (sayi03 % 2 != 0) ? "The number is odd" : "The number is even";

            Console.WriteLine(evenOrNot + "\nHit enter buttonn for exit.");
            Console.ReadLine();
        }
    }
}
