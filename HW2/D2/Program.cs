using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int clumps = 0;//D.2.8
            int count = 0;//D.2.8
            int prvnum = 0;//D.2.8
            int iter = 0;//D.2.8
            int maxcount = 0;//D.2.9
            int maxnum = 0;//D.2.10
            int minnum = 0;//D.2.10
            int sumcntavg = 0;//D.2.10
            int countcntnum = 0;//D.2.10            
            int runningsum = 0;//D.2.10
            int runningcount = 0;//D.2.10

            while (iter<6)
            {
                WriteLine("Enter a number.");
                int num = Convert.ToInt32(ReadLine());
                if (iter==0)
                {
                    prvnum = num;
                    maxnum = num;//D.2.10
                    minnum = num;//D.2.10
                    count += 1;
                    
                }
                else
                {
                    if (num == prvnum)
                    {
                        count += 1;
                        if (count>maxcount)
                        {
                            maxcount = count;
                        }

                    }
                    else //num!=prvnum
                    {
                        if (count > 1)
                        {
                            clumps += 1;
                            count = 1;
                            prvnum = num;
                        }
                        else//count=0 or 1
                        {
                            prvnum = num;
                        }
                    }
                
                }
                if (num == maxnum && num > minnum)//D.2.10
                {
                    runningsum = num + maxnum;
                    runningcount += 1;
                }
                else if (num > maxnum && num > minnum)//D.2.10
                {
                    maxnum = num;
                    sumcntavg += runningsum;
                    countcntnum += runningcount;
                    runningsum = num;
                    runningcount = 1;
                }

                iter += 1;                
            }
            if (count > 1)//determine if we the last iteration creates a clump.
            {
                clumps += 1;
            }
            WriteLine($"The number of clumps is {clumps}.");
            WriteLine($"The max count of a clump is {maxcount}.");
            WriteLine($"The center average is {sumcntavg / countcntnum}.");//D.2.10
        }
        
    }
}
