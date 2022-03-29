using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class _24_Pattern2
    {
        static void Main24(string[]args)
        {
            Console.Write("Enter number of row you required: ");
            int A = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < A; i++)
            {
                Console.ReadLine();
                for (int j = A; j > 0; j--) 
                {
                    Console.Write("*");
                }
            }
            Console.ReadLine();

         }

    }
}
