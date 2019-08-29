using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting value: ");
            int numb01 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ending value: ");
            int numb02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Increase value: ");
            int numb03 = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = numb01; i <= numb02 ; i+=numb03)
            {
                result += i;

                if (i + numb03 <= numb02)
                {
                    Console.Write(i + " + ");
                }
                else
                {
                    Console.Write(i);
                }
            }

            Console.WriteLine(" = " + result + " NERD");

            Console.ReadLine();
        }
    }
}
