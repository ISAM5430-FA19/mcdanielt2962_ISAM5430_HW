using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {/*The instructions say any two sides have to sum to be greater than the other side.
            This will always be true even if you put in all 1s since any two side will equal 2 and that is greater than 1.
            In the example 1+2!>3 but 2+3 >1.
            To make the example work, I would remove the two else if statements so that sides 1+2 must be greater than 3 or it exits the loop*/

            WriteLine("Please enter side 1 of the triagle.");
            int side1 = Convert.ToInt32(ReadLine());
            WriteLine("Please enter side 2 of the triangle.");
            int side2 = Convert.ToInt32(ReadLine());
            WriteLine("Please enter side 3 of the triangle.");
            int side3 = Convert.ToInt32(ReadLine());
            while (side1>0 && side2>0 && side3>0)
            {
                if (side1 + side2 > side3)
                {
                    WriteLine("The triangle is valid.");
                    WriteLine("Please enter side 1 of the triagle.");
                    side1 = Convert.ToInt32(ReadLine());
                    WriteLine("Please enter side 2 of the triangle.");
                    side2 = Convert.ToInt32(ReadLine());
                    WriteLine("Please enter side 3 of the triangle.");
                    side3 = Convert.ToInt32(ReadLine());
                }
                else if (side1 + side3 > side2)
                {
                    WriteLine("The triangle is valid.");
                    WriteLine("Please enter side 1 of the triagle.");
                    side1 = Convert.ToInt32(ReadLine());
                    WriteLine("Please enter side 2 of the triangle.");
                    side2 = Convert.ToInt32(ReadLine());
                    WriteLine("Please enter side 3 of the triangle.");
                    side3 = Convert.ToInt32(ReadLine());
                }
                else if (side2 + side3 > side1)
                {
                    WriteLine("The triangle is valid.");
                    WriteLine("Please enter side 1 of the triagle.");
                    side1 = Convert.ToInt32(ReadLine());
                    WriteLine("Please enter side 2 of the triangle.");
                    side2 = Convert.ToInt32(ReadLine());
                    WriteLine("Please enter side 3 of the triangle.");
                    side3 = Convert.ToInt32(ReadLine());
                }
                else
                {
                    WriteLine("This is not a valid triangle.");
                }
            }
            WriteLine("That is not a valid length");
        }
    }
}
