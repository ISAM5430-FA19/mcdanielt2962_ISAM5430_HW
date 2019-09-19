using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a numer.");
            int n = Convert.ToInt32(ReadLine());
            int iter,num;//where num is the number of numbers you are going to put in each section.
            for(iter=1;iter<=n;iter++)
            {
                for(num=1;num<=iter;num++)
                {
                    Write(num + ",");
                }
                Write(" ");
            }
            
        }
    }
}
