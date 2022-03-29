using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class Binari_trangle
    {
        static void Main8(string[] arg)
        {
            Console.Write("Enter number of rows: ");
           int Row = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= Row; i++)
            {
                Console.ReadLine();
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("*");
                    
                }
                
            }
            Console.ReadLine();
        }
    }
}
