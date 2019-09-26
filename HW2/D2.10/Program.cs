using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int iter = 0;
            int maxnum = 0;//D.2.10
            int minnum = 0;//D.2.10
            int sumcntavg = 0;//D.2.10
            int countcntnum = 0;//D.2.10            
            int runningsum = 0;//D.2.10
            int runningcount = 0;//D.2.10
            while (iter < 6)
            {
                WriteLine("Enter a number.");
                int num = Convert.ToInt32(ReadLine());
                if (iter == 0)
                {
                    maxnum = num;
                    minnum = num;
                    
                }
                else if (num==maxnum && num>minnum)
                {
                    runningsum = num + maxnum;
                    runningcount += 1;
                }
                else if (num>maxnum&& num>minnum)
                {
                    maxnum = num;
                    sumcntavg += runningsum;
                    countcntnum += runningcount;
                    runningsum = num;
                    runningcount = 1;
                   
                    
                }

                /*WriteLine($"Maxnum {maxnum}");
                WriteLine($"Minnum {minnum}");
                WriteLine($"sum {sumcntavg}");
                WriteLine($"count {countcntnum}");
                WriteLine($"prvmax {prvmaxnum}");
                WriteLine($"runningsum {runningsum}.");
                WriteLine($"runningcount{runningcount}");*/

                iter += 1;
            }
            WriteLine($"The center average is {sumcntavg / countcntnum}.");
        }
    }
}
