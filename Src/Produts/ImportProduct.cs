using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesPayment.Src.Produts
{
    class ImportProduct : Product
    {
        public ImportProduct(string nameProduct, double price, double customsFree) : base(nameProduct, price)
        {
            CustomsFree = customsFree;
        }

        public double CustomsFree { get; set; }

        public override string PriveTag()
        {
            throw new NotImplementedException();
        }

        public double TotalPrice()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return $"ImportProduct ( TotalPrice: {CustomsFree}, {base.ToString()})"   ;
        }
    }
}
