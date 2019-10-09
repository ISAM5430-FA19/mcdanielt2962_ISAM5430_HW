using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();            
            Console.Write("Enter the student number: ");
            string theNum = Console.ReadLine();
            myStudent.StuNum = theNum;
            Console.Write("Enter the student's first name: ");
            string theFname = Console.ReadLine();
            myStudent.StuFname = theFname;
            Console.Write("Enter the student's last name: ");
            string theLname = Console.ReadLine();
            myStudent.StuLname = theLname;
            Console.Write("Enter the GPA: ");
            string theGPA = Console.ReadLine();
            myStudent.StuGPA = theGPA;
            Console.Write("Enter the student classification: ");
            string theClass = Console.ReadLine();
            myStudent.Classification = theClass;
            Console.Write("Enter the student major: ");
            string theMajor = Console.ReadLine();
            myStudent.Major = theMajor;
            Console.WriteLine($"The student's name is: {myStudent.StuFname} {myStudent.StuLname}");
            Console.WriteLine($"The student's GPA is: {myStudent.StuGPA}");

        }
    }
}
