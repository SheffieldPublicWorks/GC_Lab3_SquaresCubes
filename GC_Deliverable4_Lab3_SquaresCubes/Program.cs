using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable4_Lab3_SquaresCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++++ Square and Cube Calculator ++++++++++");
            Console.WriteLine();

            int input;

            do
            {
                Console.Write("Please enter a whole number: ");
                bool valid = int.TryParse(Console.ReadLine(), out input);

                if (valid)
                {
                    Console.WriteLine("Number\tSquared\tCubed");
                    Console.WriteLine("======\t=======\t=====");

                    for (int i = 1; i <= input; i++)
                    {
                        Console.Write("{0}\t{1}\t{2}", i, Math.Pow((double)i, 2), Math.Pow((double)i, 3));
                        Console.WriteLine();
                    }
                    Console.Write("Press 'c' to continue with another calculation. Press any other key to exit: ");
                }
                else
                {
                    Console.WriteLine("Invalid input. Press 'c' to continue, or any other key to exit program.");
                }
            } while (Console.ReadLine().ToLower()[0] == 'c');

            Console.WriteLine();
            Console.WriteLine("Thanks for squaring and cubing! Bye now.");
        }
    }
}
