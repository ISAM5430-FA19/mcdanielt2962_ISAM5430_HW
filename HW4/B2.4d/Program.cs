using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2._4d
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char i='A';i<='H';i++)
            {
                for(char j='A';j<='H';j++)
                {
                    for (char z='A';z<='H';z++)
                    {
                        
                        if (j=='A' || j=='E')
                        {
                            if(i!=j && i!=z && j!=z)
                            {
                                Write($"{i}{j}{z}, ");
                            }                           
                            
                        }
                        else
                        {
                            Write($"{i}{j}{z}, ");
                        }
                    }
                }
            }
            WriteLine();
        }
    }
}
