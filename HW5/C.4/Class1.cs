using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._4
{
    class Park
    {
        private string _name;
        private string _location;
        private string _type;
        private string _facility;
        private decimal _fee;
        private int _empCount;
        private int _visCount;
        private decimal _budget;
        

        public void SetName(string name)
        {            
            _name = name;            
        }
        public string GetName()
        {
            return _name;
        }
        public void SetLocation(string location)
        {
            _location = location;
        }
        public string GetLocation()
        {
            return _location;
        }
        public void SetParkType(string type)
        {
            _type = type;
        }
        public string GetParkType()
        {
            return _type;
        }
        public void SetFacility(string facility)
        {
            _facility = facility;
        }
        public string GetFacility()
        {
            return _facility;
        }
        public void SetFee(decimal fee)
        {
            _fee = fee;
        }
        public decimal GetFee()
        {
            return _fee;
        }
        public void SetEmpCount(int empcount)
        {
            _empCount = empcount;
        }
        public int GetEmpCount()
        {
            return _empCount;
        }
        public void SetVisCount(int visCount)
        {
            _visCount = visCount;
        }
        public int GetVisCount()
        {
            return _visCount;
        }
        public void SetBudget (decimal budget)
        {
            _budget = budget;
        }
        public decimal GetBudget()
        {
            return _budget;
        }
        public decimal GetCostPerVis()
        {
            return _budget / _visCount;
        }        
        
        public decimal GetRevenue()
        {
            return _visCount * _fee;
        }
        public override string ToString()
        {
            return ($"Name: {_name}, location: {_location}, type: {_type}, facilities: {_facility}, number of employees: {_empCount}, number of visitors last year {_visCount}, budget {_budget.ToString("C")}, cost: {(_budget / _visCount).ToString("C")}, revenue: {(_visCount * _fee).ToString("C")}.");
        }
    }
}
