using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class sum_of_digits
    {
        static void Main6(string[]arg)
        {
            int sum = 0;
            Console.Write("Enter a Number: ");
            int Num = Int32.Parse(Console.ReadLine());
            int Number = Num;
            while (Number > 0) 
            {
                int reminder = Number % 10;
                sum = sum + reminder;
                Number = Number / 10;
            }
            Console.WriteLine("Sum of digits= "+sum);
            Console.ReadLine();
        }
    }
}
