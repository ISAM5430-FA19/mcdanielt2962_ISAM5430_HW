using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorway myMotorway = new Motorway();
            Console.Write("Enter the name of the motorway: ");
            string myName = Console.ReadLine();
            myMotorway.Name = myName;
            Console.Write("Enter the type of motorway: ");
            string myType = Console.ReadLine();
            myMotorway.Type = myType;
            Console.Write("Enter the direction: ");
            string myDirection = Console.ReadLine();
            myMotorway.Direction = myDirection;
            Console.Write("Enter the surface type: ");
            string mySurface = Console.ReadLine();
            myMotorway.Surface = mySurface;
            Console.Write("Enter number of lanes: ");
            int myLanes = Convert.ToInt32(Console.ReadLine());
            myMotorway.Lanes = myLanes;
            Console.Write("Toll or No Toll? ");
            string myToll = Console.ReadLine();
            myMotorway.Toll = myToll;
            Console.Write("Who maintains the motorway? ");
            string myMaint = Console.ReadLine();
            myMotorway.MantainingParty = myMaint;
            Console.WriteLine($"The name of the roadway is {myMotorway.Direction} {myMotorway.Name} {myMotorway.Type}");
            Console.WriteLine($"The name of the roadway is {myMotorway.Direction} {myMotorway.Name} {myMotorway.Type}, {myMotorway.Toll}");
            Console.WriteLine($"The name of the roadway is {myMotorway.Direction} {myMotorway.Name} {myMotorway.Type} with {myMotorway.Lanes} lanes");
            Console.WriteLine(myMotorway.ToString());

        }
    }
}
