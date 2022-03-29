using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class _19_Addition_Of_Digits
    {
        static void Main19(string[]args)
        {
            int A, B, SUM = 0;
            Console.WriteLine("Enter Number: ");
            A = Int32.Parse(Console.ReadLine());

            while (A > 0) 
            {
                B = A % 10;
                SUM = SUM + B;
                A = A / 10;
            }
            Console.WriteLine("addition of all digits= " + SUM);
            Console.ReadLine();
        }
    }
}
