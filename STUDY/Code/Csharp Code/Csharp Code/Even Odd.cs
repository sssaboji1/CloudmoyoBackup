using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class Even_Odd
    {
        static void Main13(string[] args)
        {
            int number;
            Console.Write("Enter number: ");
            number = Int32.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Enter number is even number");
            }
            else
            {
                Console.WriteLine("Enter number is odd number");
            }
            Console.Read();
        }

    }
}
