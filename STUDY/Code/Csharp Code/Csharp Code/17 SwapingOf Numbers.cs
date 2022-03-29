using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class _17_SwapingOf_Numbers
    {
        static void Main17(string[]args)
        {
            int A,B,C;
            Console.WriteLine("enter first number: ");
            A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            B = Int32.Parse(Console.ReadLine());

            C = A;
            A = B;
            B = C;
            Console.WriteLine("Swaping of numbers as below:");
            Console.WriteLine("First Number= " + A+" and Second Number= "+B);
            Console.ReadLine();
        }
    }
}
