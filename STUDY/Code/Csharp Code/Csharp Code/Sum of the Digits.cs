using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Code
{
    class Sum_of_the_Digits
    {
        static void Main5(string[] args)
        {
            long number = 1757051;
            long multiplication = 1;    

            for(int i = 1; i <= number; i++)
            {
                if((number % i) == 0 )
                {
                    bool flag = true;
                    for(int j = 2; j < i; j++)
                    {
                        if((i % j) == 0)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if(flag)
                    {
                        multiplication = multiplication * i;
                    }
                }
            }
            Console.WriteLine(multiplication);

        }
    }
}
