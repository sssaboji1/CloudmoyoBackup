using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class Swap_numbers
    {
        static void Main4(string[] args)
        {
            int a, b, c;
            Console.Write("Enter first number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Int32.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After swaping");
            Console.WriteLine("First number: "+a);
            Console.WriteLine("Second number: "+b);
            Console.ReadLine();
        }
    }
}
