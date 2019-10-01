using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i=1;i<=5;i++)
            {
                for(int j=i+1;j<=5; j++)
                {
                    if(i!=j)
                    {
                        sum = sum + i * j;
                        Write(i + ", " + j + "; ");
                    }
                }
            }
            WriteLine(sum);
        }
    }
}
