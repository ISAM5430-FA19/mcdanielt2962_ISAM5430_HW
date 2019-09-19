using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal rate = .05m;
            //int rc=1
            decimal amt = 1000;
            int year = 1;
            WriteLine("Year\t|Rate \t|Amount");
            for(rate=.05m;rate<=.10m;rate+=.01m)            
            {
                for(year=1;year<=10;year++)                
                {
                    amt = amt * (1 + rate);
                    Write(string.Format("{0,2}", year) + "\t" + "|");
                    Write(string.Format("{0,6}", rate) + "\t" + "|");
                    WriteLine(" " + string.Format("{0:C}", amt));                    
                    
                }
                WriteLine("\n");
                amt = 1000;
                
                
            }
        }
    }
}
