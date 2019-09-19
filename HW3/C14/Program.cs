using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C14
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            for (row=1;row<=10;++row)//pattern a
            {
                for(col=1;col<=row;++col)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine("");
            for (row = 10; row >= 1; --row)//pattern b
            {
                for ( col = 1; col <= row; ++col)
                {
                    Write("*");
                }

                WriteLine();
            }
            WriteLine("");
            row = 10;//pattern c
            int iter, space, astr;

            for (iter=0;iter<=row;iter++)
            {
                for(space=1;space<=iter;space++)
                {
                    Write(" ");
                }
                for(astr=1;astr<=row-iter; astr++)
                {
                    Write("*");
                }
                WriteLine("");
             }
            WriteLine("");
            row = 10;//pattern d
            

            for (iter = 1; iter <= row; iter++)
            {
                for (space = 1; space <= row - iter; space++)
                {
                    Write(" ");
                }
                for (astr = 1; astr <= iter; astr++)
                {
                    Write("*");
                }
                WriteLine("");
            }
        }
    }
}
