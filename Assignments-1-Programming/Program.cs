using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_1_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            string inputNr1 = Console.ReadLine();
            Console.WriteLine("Enter number 2");
            string inputNr2 = Console.ReadLine();

            int nr1 = int.Parse(inputNr1);
            int nr2 = int.Parse(inputNr2);

            if (nr1 < nr2) 
            {
                Console.WriteLine("Number one is the lowest value.");
                Console.WriteLine("Number two is the highest value.");

            } 
            else
            {
                Console.WriteLine("Number two is the lowest value.");
                Console.WriteLine("Number one is the highest value.");
            }

            Console.ReadKey();
        }
    }
}
