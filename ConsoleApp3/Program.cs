using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayWeek = (int)DateTime.Now.DayOfWeek;
            int dayYear = (int)DateTime.Now.DayOfYear;
            DateTime dtNow = DateTime.Now;

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Day of Year {dayYear}\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Day of Week {dayWeek}\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Now {dtNow}\n");

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hit enter for exit.");

            Console.ReadKey();
        }
    }
}
