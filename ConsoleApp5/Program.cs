using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //char secim = 'y';

            //while (secim == 'y')
            //{
            //    Console.WriteLine("First number: ");
            //    int numb01 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Second number: ");
            //    int numb02 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(Convert.ToInt32(numb01 + numb02) + "Devam etmek istiyor musunuz?: ");

            //    secim = Convert.ToChar(Console.ReadLine());
            //}

            char secim;

            do
            {
                Console.WriteLine("First number: ");
                int numb01 = int.Parse(Console.ReadLine());

                Console.WriteLine("Second number: ");
                int numb02 = int.Parse(Console.ReadLine());

                Console.WriteLine(Convert.ToInt32(numb01 + numb02) + "Devam etmek istiyor musunuz?: ");

                secim = Convert.ToChar(Console.ReadLine());
                
            } while (secim != 'n');

        }
    }
}
