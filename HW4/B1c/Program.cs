﻿using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        for (int z = 1; z <= 5; z++)
                        {
                            if (z != j && i != z)
                            {
                                sum = sum + i * j * z;
                                
                            }
                        }
                    }
                }
            }
            WriteLine(sum);
        }
    }
}
