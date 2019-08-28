using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter for begin.");
            Console.ReadLine();

            Console.WriteLine("Give me the number: ");
            int? sayi = int.Parse(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("1- 2- 3");
                    break;

                case 4:
                case 5:
                case 6:
                    Console.WriteLine("4- 5- 6");
                    break;

                default:
                    Console.WriteLine("Evolution trippy video music");
                    break;
            }

            Console.WriteLine("\nHit enter for exit.\n");
            Console.ReadLine();
            Console.WriteLine("Bye..");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Bye...");
            System.Threading.Thread.Sleep(2000);

        }
    }
}
