using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Abstract;
using FactoryMethod.Concrete.Products;

namespace FactoryMethod.Concrete.ConcreteCreator
{
    public class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {

            return new ConcreteProduct1();
        }
    }
}
