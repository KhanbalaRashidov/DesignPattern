using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Factory;
using AbstractFactory.Concrete.ProductA;
using AbstractFactory.Concrete.ProductB;

namespace AbstractFactory.Concrete.Factory
{
    public class ConcreteFactory1:IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
