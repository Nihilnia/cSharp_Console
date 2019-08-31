using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays

            string[] students = new string[20];

            students[2] = "Nihil";
            students[4] = "Nihilx";
            students[6] = "Nihilxx";

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(i + " " + students[i]);
            }



            int[] numbers = {1, 2, 3, 4, 5};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i + "_ " + numbers[i]);
            }


            //Exercise

            Console.WriteLine("How much students you wanna add?: ");
            int userChoice = int.Parse(Console.ReadLine());

            int[] studentNumber = new int[userChoice];
            string[] studentName = new string[userChoice];

            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}'s number: ");
                int numb = int.Parse(Console.ReadLine());
                studentNumber[i] = numb;

                Console.WriteLine($"Student {i + 1}'s name:");
                string name = Console.ReadLine();
                studentName[i] = name;
                Console.WriteLine("\n");
            }

            Console.WriteLine("All Students:\n\n");
            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine("\n" + "Student number: " + studentNumber[i] + " " + studentName[i] + "\n");
            }


            Console.ReadLine();
        }
    }
}
