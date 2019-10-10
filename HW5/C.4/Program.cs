using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Park myPark = new Park();
            Write("Enter park name. ");
            string myName = ReadLine();
            myPark.SetName(myName);
            Write("Enter location. ");
            string myLocation = ReadLine();
            myPark.SetLocation(myLocation);
            Write("Enter type of park. ");
            string myType = ReadLine();
            myPark.SetParkType(myType);
            Write("Enter facilities available. ");
            string myFacilities = ReadLine();
            myPark.SetFacility(myFacilities);
            Write("Enter fee. ");
            decimal myFee = decimal.Parse(ReadLine());
            myPark.SetFee(myFee);
            Write("Enter the number of employees. ");
            int myEmp = Convert.ToInt32(ReadLine());
            myPark.SetEmpCount(myEmp);
            Write("Enter number of visitors in the last 12 months. ");
            int myVis = Convert.ToInt32(ReadLine());
            myPark.SetVisCount(myVis);
            Write("Enter the annual budget. ");
            decimal myBudget = decimal.Parse(ReadLine());
            myPark.SetBudget(myBudget);
            WriteLine($"The name, location and type of park is: {myPark.GetName()}, {myPark.GetLocation()}, {myPark.GetParkType()}.");
            WriteLine($"The name, location and facilities available is: {myPark.GetName()}, {myPark.GetLocation()}, {myPark.GetFacility()}.");
            WriteLine($"The cost per visitor is ${myPark.GetCostPerVis()}.");
            WriteLine($"The revenue is ${myPark.GetRevenue()}.");
            WriteLine(myPark.ToString());
        }
    }
}
