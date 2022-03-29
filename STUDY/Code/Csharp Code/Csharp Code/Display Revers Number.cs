using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class Display_Revers_Number
    {
        
        static void Main7(string[]arg)
        {
            int revers = 0;
            Console.Write("Enter a number: ");
            int num = Int32.Parse(Console.ReadLine());
            while (num > 0)
            {
                revers = revers * 10;
                revers = revers + num % 10;
                num = num / 10; 
            }
            Console.Write("revers number : " + revers);
            Console.ReadLine();
        }
    }
}
