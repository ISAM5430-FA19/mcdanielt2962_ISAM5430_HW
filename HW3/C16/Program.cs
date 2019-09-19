using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a number.");
            int n = Convert.ToInt32(ReadLine());
            int iter, num,z,mult ; //where num is the number of numbers per line. and where z is number of zeros printed
           // int prvnum = 1;
            for (iter=1;iter<=n;iter++)
            {
                for (z = 1; z <= n-iter; z++)
                {
                    Write("0,");
                   
                }
                for (num=1;num<=iter;num++)//cannot figure out how to update each position in 3,2,1. i can get 001,012,123
                {


                    
                    Write((num * iter) + ",");
                    
                    
                    
                }
                WriteLine();
            }
                
                
        }
    }
}
