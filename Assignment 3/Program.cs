using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            string inputNr1 = Console.ReadLine();
            Console.WriteLine("Enter your second number:");
            string inputNr2 = Console.ReadLine();
            Console.WriteLine("Enter your third number:");
            string inputNr3 = Console.ReadLine();

            int nr1 = int.Parse(inputNr1);
            int nr2 = int.Parse(inputNr2);
            int nr3 = int.Parse(inputNr3);

            if(nr1 > nr3 && nr2 > nr3)
            {
                Console.WriteLine("The third number is the smallest of the three.");
            }
            else
            {
                Console.WriteLine("The third number is not the smallest of the three.");
            }
            Console.ReadKey();

        }
    }
}
