using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int iter = 0;
            int count = 0;
            int longcount = 0;
            int prvnum = 0;
            int prvnum2 = 0;
            while(iter<4)
            {
                WriteLine("Please enter a number.");
                int num = Convert.ToInt32(ReadLine());
                
                if (iter==0)
                {
                    prvnum2 = num;
                    count += 1;
                }
                else if (iter==1)
                {
                    prvnum = num;
                    count += 1;
                }
                else if (prvnum>prvnum2 && num-prvnum==prvnum-prvnum2)
                {
                    count += 1;
                    prvnum2 = prvnum;
                    prvnum = num;
                }
                else if (prvnum<prvnum2 && num-prvnum==prvnum-prvnum2)
                {
                    count += 1;
                    prvnum2 = prvnum;
                    prvnum = num;
                }
                else
                {
                    longcount = count;
                    count = 0;
                    prvnum2 = prvnum;
                    prvnum = num;
                }
                iter += 1;

                WriteLine($"count {count}");
                WriteLine($"prvnum2 {prvnum2}");
                WriteLine($"prvnum {prvnum}");
                WriteLine($"longcount {longcount}");
                

            }
            if (count>longcount)
            {
                longcount = count;
            }
            WriteLine($"The longest string of consecutive numers is {longcount}.");
        }
    }
}
