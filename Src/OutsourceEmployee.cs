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
        /// additional expenses
        /// </summary>
        public double AdditionCharge { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="valuePerHour"></param>
        /// <param name="hours"></param>
        /// <param name="name"></param>
        public OutsourceEmployee(string name,double valuePerHour, int hours, double additionCharge) : base(name,valuePerHour, hours )
        {
           AdditionCharge = additionCharge;
        }

        public override string ToString()
        {
            return $"OutsourceEmployee (AdditionCharge: {AdditionCharge},{base.ToString()}) ";
        }

        /// <summary>
        /// 
        /// payment of the common employee plus 110% of additional expenses
        /// </summary>
        /// <returns></returns>
        public override double Payment()
        {
           // base.Payment();
            return base.Payment() + (1.1  * AdditionCharge);
        }
    }
}
