using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            string inputNr1 = Console.ReadLine();
            Console.WriteLine("Enter your second number: ");
            string inputNr2 = Console.ReadLine();

            int nr1 = int.Parse(inputNr1);
            int nr2 = int.Parse(inputNr2);

            int nr3 = nr1 % nr2;
            int nr4 = nr2 % nr1;

            if(nr3 > 0)
            {
                Console.WriteLine("Numbers are no multiples");
            }
            else if(nr4 > 0)
            {
                Console.WriteLine("Numbers are no multiples");
            }
            else if(nr3 == 0)
            {
                Console.WriteLine("Number 1 is a multiple of Number 2");
            }
            else if(nr4 == 0)
            {
                Console.WriteLine("Number 2 is a multiple of Number1 ");
            }

            // NOT DONE CONTINUE ON THIS
            Console.ReadKey();

        }
    }
}
