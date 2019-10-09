using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._1
{
    class Student
    {
        private string _studentnumber;
        private string _stufname;
        private string _stulname;
        private string _stuGPA;
        private string _classification;
        private string _major;
        public string StuNum
        {
            get
            {
                return _studentnumber;
            }
            set
            {
                _studentnumber = value;
            }
        }
        
        public string StuFname
        {
            get
            {
                return _stufname;
            }
            set
            {
                _stufname = value;
            }
        }
        public string StuLname
        {
            get
            {
                return _stulname;
            }
            set
            {
                _stulname = value;
            }
        }
        public string StuGPA
        {
            get
            {
                return _stuGPA;
            }
            set
            {
                _stuGPA = value;
            }
        }
        public string Classification
        {
            get
            {
                return _classification;
            }
            set
            {
                _classification = value;
            }
        }
        public string Major
        {
            get
            {
                return _major;
            }
            set
            {
                _major = value;
            }
        }

    }
}
