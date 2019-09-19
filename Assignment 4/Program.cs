using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
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

            int sum = (nr1 + nr2 + nr3);
            string sum1 = sum.ToString();
            Console.WriteLine("Your sum is: " + sum1);

            int average = sum / 3;
            string average1 = average.ToString();
            Console.WriteLine("Your average is: " + average1);

            int product = nr1 * nr2 * nr3;
            string product1 = product.ToString();
            Console.WriteLine("Your product is: " + product1);

            if(nr1 > nr2 && nr1 > nr3)
            {
                Console.WriteLine("Your highest number is: " + nr1);
            }
            else if (nr2 > nr1 && nr2 > nr3)
            {
                Console.WriteLine("Your highest number is: " + nr2);
            }
            else if(nr3 > nr1 && nr2 > nr1)
            {
                Console.WriteLine("Your highest number is: " + nr3);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            if (nr1 < nr2 && nr1 < nr3)
            {
                Console.WriteLine("Your lowest number is: " + nr1);
            }
            else if (nr2 < nr1 && nr2 < nr3)
            {
                Console.WriteLine("Your lowest number is: " + nr2);
            }
            else if (nr3 < nr1 && nr2 < nr1)
            {
                Console.WriteLine("Your lowest number is: " + nr3);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.ReadKey();
        }
    }
}
