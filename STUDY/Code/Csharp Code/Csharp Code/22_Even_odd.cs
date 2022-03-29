using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class _22_Even_odd
    {
        static void Main22(string[]ars)
        {
            Console.Write("Enter a Number: ");
            int A = Int32.Parse(Console.ReadLine());

            if (A % 2 == 0)  
            {
                Console.WriteLine("Enter number is even number");
            }
            else
            {
                Console.WriteLine("Entered number is odd number");
            }
            Console.ReadLine();

        }
    }
}
