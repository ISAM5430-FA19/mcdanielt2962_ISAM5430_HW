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

            while (iter<6)
            {
                WriteLine("Enter a number.");
                int num = Convert.ToInt32(ReadLine());
                if (iter==0)
                {
                    prvnum = num;
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
                WriteLine(count);
                iter += 1;                
            }
            if (count > 1)//determine if we the last iteration creates a clump.
            {
                clumps += 1;
            }
            
            WriteLine($"The number of clumps is {clumps}.");
            WriteLine($"The max count of a clump is {maxcount}.");


        }
    }
}
