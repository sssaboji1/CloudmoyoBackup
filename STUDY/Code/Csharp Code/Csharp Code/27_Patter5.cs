using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class _27_Patter5
    {
        static void Main27(string[]args)
        {
            Console.Write("Enter Number of row: ");
            int A = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < A; i++)
            {
                for (int j = A; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int p = 0; p <= i; p++)
                {
                    Console.Write("*");
                }
                Console.ReadLine();
            }
        }
    }
}
