using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class _25_Patter3
    {
        static void Main25(string[] args)
        {
            Console.Write("Enter Number of rows :");
            int A = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < A; i++)
            {
                for (int j = A; j > i; j--)
                    Console.Write(" ");
                {
                    for (int M  = 1; M <= i; M++)
                    {
                        Console.Write("*");
                    }
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
