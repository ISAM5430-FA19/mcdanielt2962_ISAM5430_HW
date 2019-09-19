using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int r,c,p;
            WriteLine("x  1  2  3  4  5  6  7  8  9");
            for (r = 1; r<=9; r++)
            {                
                Write(r);
                for (c=1; c <= 9; c++)
                {                   
                    p = r * c;
                    Write(" ");
                    Write(string.Format("{0,2}",p));  
                }

                WriteLine(" ");
            }
        }
    }
}
