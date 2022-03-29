using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class _21_Display_Reverse_Number
    {
        static void Main21(string[] args)
        {
            int A, number=0, Reverse =0;
            Console.WriteLine("enter a number: ");
            A = Int32.Parse(Console.ReadLine());

            while (A > 0)
            {
                Reverse = Reverse * 10;
                Reverse = Reverse + A % 10;          
                A = A / 10;

            }
            Console.WriteLine("Revers Number: " + Reverse);
            Console.ReadLine();

        }
    }
}
