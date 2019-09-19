using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, ctr,enno ;
            Console.Write("Enter a number ");
            enno = Convert.ToInt32(Console.ReadLine());
            
            for (num = 1; num<=enno; num++)//starting at iteration 1, going to iteration that is equal to user input.
            {
                ctr = 0;

                for(i=2;i<=num/2; i++) //could use i<=num-1 but /2 saves computing time as it only needs to check up to half the number of iterations.
                {
                    if(num%i==0)
                    {
                        ctr++;
                        break;
                    }
                }
                if(ctr==0&&num!=1)
                {
                    Write(num+" ");
                }
            }
            WriteLine("are primes up to your number.");
            
        }
    }
}
