using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete.ProductB
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string FunctionB()
        {
            return "Result B1";
        }

        public string AnotherFunctionB(IAbstractProductA productA)
        {
            var result = productA.FunctionA();

            return $"Result B1 with {result}";
        }
    }
}
