using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Concrete
{
    public class Product
    {
        private  List<object> _products = new List<object>();

        public void Add(string productName)
        {
            this._products.Add(productName);
        }

        public string GetProducts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._products.Count; i++)
            {
                str += this._products[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return $" Product :{str} \n";
        }
    }
}
