using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesPayment.Src.Produts
{
    class UsedProduct : Product
    {
      

        public DateTime ManufatureDate { get; set; }

        public UsedProduct(DateTime manufatureDate, string nameProduct, double price) :
            base (nameProduct, price)
        {
            ManufatureDate = manufatureDate;
        }

        public override string PriveTag()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"UsedProduct ( ManufatureDate: {ManufatureDate}, {base.ToString()})";
        }
    }
}
