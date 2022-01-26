using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesPayment.Src
{
    class OutsourceEmployee : Employee
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valuePerHour"></param>
        /// <param name="hours"></param>
        /// <param name="name"></param>
        public OutsourceEmployee(double valuePerHour, int hours, string name) : base(valuePerHour, hours, name)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private double additionalCharge()
        {
            return 0.0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private double Payment()
        {
            return 0.0;
        }
    }
}
