using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ranging from 1 to 4:");
            string input = Console.ReadLine();
            int input2 = int.Parse(input);

            switch(input2)
            {
                case 1:
                    Console.WriteLine("diamonds");
                    break;

                case 2:
                    Console.WriteLine("spades");
                    break;

                case 3:
                    Console.WriteLine("hearts");
                    break;

                case 4:
                    Console.WriteLine("clubs");
                    break;
            }
            Console.ReadKey();

        }
    }
}
