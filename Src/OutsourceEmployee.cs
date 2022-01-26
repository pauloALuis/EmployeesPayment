using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesPayment.Src
{
    class OutsourceEmployee : Employee
    {
        public OutsourceEmployee(double valuePerHour, int hours, string name) : base(valuePerHour, hours, name)
        {
        }

        private double additionalCharge()
        {
            return 0.0;
        }

        private double Payment()
        {
            return 0.0;
        }
    }
}
