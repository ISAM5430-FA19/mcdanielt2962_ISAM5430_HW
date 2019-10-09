using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._2
{
    class Motorway
    {
        private string _name;
        private string _type;
        private string _direction;
        private string _surface;
        private int _lanes;
        private string _toll;
        private string _mantParty;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public string Direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;
            }
        }
        public string Surface
        {
            get
            {
                return _surface;
            }
            set
            {
                _surface = value;
            }
        }
        public int Lanes
        {
            get
            {
                return _lanes;
            }
            set
            {
                _lanes = value;
            }
        }
        public string Toll
        {
            get
            {
                return _toll;
            }
            set
            {
                _toll = value;
            }
        }
        public string MantainingParty
        {
            get
            {
                return _mantParty;
            }
            set
            {
                _mantParty = value;
            }
        }
        public override string ToString()
        {
            return ($"Direction-{Direction}, Name-{Name}, Type-{Type}, Surface-{Surface}, Toll-{Toll}, Maintaining Party-{MantainingParty}");
        }
    }
}
