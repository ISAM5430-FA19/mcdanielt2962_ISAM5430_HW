using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2._5b
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i='A';i<='H';i++)
            {
                for (char j='A';j<='H';j++)
                {
                    if (i!='A' && i!= 'E')
                    {

                        if (j=='A' || j=='E')
                        {
                            Write($"{i}{j}, ");
                        }
                
                
                    }
                    for (char z = 'A'; z <= 'H'; z++)
                    {
                        if (i != 'A' && i != 'E')
                        {
                            if(z=='A'||z=='E')
                            {
                                Write($"{i}{j}{z}, ");
                            }
                            
                        }

                    }
                }
            }
            WriteLine();
        }
    }
}
