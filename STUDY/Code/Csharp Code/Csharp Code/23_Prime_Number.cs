using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class _23_Prime_Number
    {
        static void Main23(string[]args)
        {
            Boolean flag=false;
            Console.Write("Enter Number: ");
            int A = Int32.Parse(Console.ReadLine());

            
            for (int i = 2; i < A; i++)
            {
                if (A % i == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Enterd number is Non-prime number");
            }
            else
            {
                Console.WriteLine("Enterd number is Prime number");
            }
            Console.ReadLine();
        }
    }
}
