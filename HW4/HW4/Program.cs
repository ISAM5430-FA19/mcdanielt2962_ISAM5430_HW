using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a number.");
            int num = Convert.ToInt32(ReadLine());
            int sum = 0;
            int count = 0;
            int iter = 0;
            for(iter=num;iter>=1;iter--)
            {
                count += 1;
                iter = iter / 10;
                
            }
            for(iter=0;iter<count;iter++)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            WriteLine(sum);
        }
    }
}
