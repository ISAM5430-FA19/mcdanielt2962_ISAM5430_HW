using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int iter = 0;
            int count1 = 0;
            int count4 = 0;
            while(iter<5)
            {
                WriteLine("Enter a number.");
                int num = Convert.ToInt32(ReadLine());
                if (num==1)
                {
                    count1 += 1;
                }
                else if (num==4)
                {
                    count4 += 1;
                }
                iter += 1;
            }
            
            if (count1>count4)
            {
                WriteLine("There are more ones than fours.");
            }
            else
            {
                WriteLine("There are not more ones than fours.");
            }
        }
    }
}
