using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class Hello
    {
        static void Main3(string[] args)
        {
            int number;
            char Grade;
            Console.Write("Enter number: ");
            number = Int32.Parse(Console.ReadLine());

            if (number > 10)
            {
                Console.WriteLine("Grade A");
                Grade = 'A';
            }
            else
            {
                Console.WriteLine("Grade B");
                Grade = 'B';
            }

            Console.Write("Number is " +Grade+ " Grade");
            Console.Read();
        }
    }
}
