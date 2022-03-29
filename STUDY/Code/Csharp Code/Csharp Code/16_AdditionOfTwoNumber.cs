using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class _16_AdditionOfTwoNumbers
    {
        static void Main16(string[]args)
        {
            int A,B,Sum=0;
          

            Console.WriteLine("Enter first number: ");
            A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            B = Int32.Parse(Console.ReadLine());

            Sum = A + B;
            Console.WriteLine("Addition of two entered numbers= "+Sum);
            Console.ReadLine();

        }
    }
}
