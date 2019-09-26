using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int iter = 0;
            int alt1 = 0;
            int alt2 = 0;            
            int counthills = 0;
            while(iter<20)
            {
                WriteLine("Enter a number.");
                int num = Convert.ToInt32(ReadLine());
                if (iter==0)
                {
                    alt1 = num;
                }
                else if (num<=alt1 && alt2==0)
                {
                    alt1 = num;
                }
                else if (num>alt1 && alt2==0)
                {
                    alt2 = num;
                }
                else if (num<alt2)
                {
                    alt1 = num;
                    alt2 = 0;
                    counthills += 1;
                }
                else
                {
                    alt2 = num;
                }
                iter += 1;
                WriteLine($"alt1 {alt1}");
                WriteLine($"alt2 {alt2}");                
                WriteLine($"counthills {counthills}");
            }
            WriteLine($"The number of hills is {counthills}.");


        }
    }
}
