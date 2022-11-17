using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete.Products
{
    public class ConcreteProduct2:IProduct
    {
        public string Operation()
        {
            return "Result Product2";
        }
    }
}
