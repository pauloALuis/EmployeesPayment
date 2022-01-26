using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesPayment.Src.Produts
{
    abstract class Product
    {
        public string NameProduct { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameProduct"></param>
        /// <param name="price"></param>
        public Product(string nameProduct, double price)
        {
            NameProduct = nameProduct;
            Price = price;
        }

        public abstract string PriveTag();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Product({NameProduct}, {Price}€)";
        }
    }
}
