using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class EvenNumber
    {
        static void Main12(string[]args)
        {
            Console.WriteLine("Enter a Number: ");
            int NUMBER = Int32.Parse(Console.ReadLine());

            
            if (NUMBER % 2 == 0)
            {
                Console.WriteLine("Number is even numberrrrrrrrr");
            }
            else
            {
                Console.WriteLine("Number is odd number");
            }
            Console.ReadLine();
        }
    }
}
