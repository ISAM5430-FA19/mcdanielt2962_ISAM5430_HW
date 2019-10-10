using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Date myDate = new Date(10,02,2019);
            WriteLine($"The date is {myDate.GetDisplayDate()}");
        }
    }
}
