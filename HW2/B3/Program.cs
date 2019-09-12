using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a GPA number.");
            decimal gpa = Convert.ToDecimal(ReadLine());
            int gpavalue = Convert.ToInt32((int)(3 * gpa + .5m));

            if (gpa < 0 || gpa > 4)
            {
                Write("This number is invalid and must be between 0 and 4");
            }

            else if (gpavalue > 10)
            {
                Write("The grade is an A");

            }
            else if (gpavalue > 7)
            {

                Write("The letter grade is B");

            }
            else if (gpavalue > 4)
            {

                Write("The letter grade is C");
            }
            else if (gpavalue > 2)
            {
                Write("The letter grade is D");
            }
            else
            {

                WriteLine("The letter grade is F");
            }
            if (gpavalue == 11 || gpavalue == 8 || gpavalue == 5)
            {
                WriteLine("-");
            }
            else if (gpavalue == 10 || gpavalue == 7 || gpavalue == 4 || gpavalue == 2)
            {
                WriteLine("+");
            }
            else
            {
                WriteLine();
            }

        }

    }
}
