using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class _26_Pattern4
    {
        static void Main26(string[]args)
        {
            Console.Write("Enter Number of rows you want: ");
            int A = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < A; i++)
            {
                for (int j = A; j> i; j--)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m <=i; m++)
                {
                    Console.Write("*");
                }
                for (int m = 1; m <= i; m++)
                {
                    Console.Write("*");
                }
                Console.ReadLine();
            }
        }
    }
}
