using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class _28_Pattern5
    {
        static void Main(string[]args)
        {
            Console.Write("Enter number of rows: ");
            int A = Int32.Parse(Console.ReadLine());

            for (int i = A; i > 0; i--) 
            {
                for (int j = 0; j < A; j++) 

                Console.Write("*");
            }
            Console.ReadLine();
        }
    }
}
