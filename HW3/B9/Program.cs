using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, iter, var, count;
            WriteLine("Enter an integer.");
            num = Convert.ToInt32(ReadLine());
            count = 0;
            for (iter = num; iter >= 0; iter--) //counts the number of bits
            {
                count += 1;
                iter /= 2;
                
            }
            while (count % 8 != 0)//adds leading zeros to fill out the byte
            {
                count += 1;
                
            }

            for (iter = count-1; iter >= 0; iter--)//iter=count-1 because iteration 0 counts as the first bit
            {
                var = num >> iter;
                if (Convert.ToBoolean(var & 1))
                {
                    Write("1");
                }
                else
                {
                    Write("0");
                }
            }
            WriteLine();
        }
    }
}
