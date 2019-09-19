using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a positive number.");
            int n = Convert.ToInt32(ReadLine());
            int row = 0;
            int col = 0;
            for (row=n; row>=1;--row)
            {
                for (col=1;col<=n;++col)
                {
                    Write("X");
                    
                }
                WriteLine();
                
            }
            
        }
    }
}
