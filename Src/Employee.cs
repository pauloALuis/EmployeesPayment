using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesPayment.Src
{
    class Employee
    {
        private double _valuePerHour;
        private int _hours;
        private string _name;

        public double ValuePerHour { get => _valuePerHour; set => _valuePerHour = value; }
        public int Hours { get => _hours; set => _hours = value; }
        public string Name { get => _name; set => _name = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valuePerHour"></param>
        /// <param name="hours"></param>
        /// <param name="name"></param>
        public Employee(double valuePerHour, int hours, string name)
        {
            _valuePerHour = valuePerHour;
            _hours = hours;
            _name = name;
        }

        public Employee()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Employee(name{_name}, hours: {_hours},valuePerHour: {_valuePerHour})";
        }
    }
}
