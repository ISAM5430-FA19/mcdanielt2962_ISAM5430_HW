using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a number.");
            int num = Convert.ToInt32(ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int iter = 0;
            int count = 0;
            for(iter=num;iter>=1;iter--)
            {
                count += 1;
                iter = iter / 10;
            }
            for(iter=0;iter<count;iter++)
            {
                if (iter % 2 == 0)
                {
                    sum1 = sum1 + num % 10;
                    num = num / 10;
                }
                else
                {
                    sum2 = sum2 + num % 10;
                    num = num / 10;
                }

            }
            if((sum1-sum2)%11==0)
            {
                WriteLine("The number is divisible by 11");

            }
            else
            {
                WriteLine("The number is not divisible by 11.");
            }
        }
    }
}
