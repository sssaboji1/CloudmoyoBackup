using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class Prime_Number
    {
        static void Main2(string[] args)
        {
            int Number;
            Console.Write("Enter a number : ");
            Number= Convert.ToInt32(Console.ReadLine());

            int M = Number/ 2;
            for (int i = 2; i <= M; i++)
            {
                int reminder = Number % i;

                if (reminder == 0)
                {
                    Console.WriteLine("Non-Prime Number");
                }
            }
                
                {
                    Console.WriteLine("Prime Number");
                   
                }
            
            Console.ReadLine();
        }
    }
}
