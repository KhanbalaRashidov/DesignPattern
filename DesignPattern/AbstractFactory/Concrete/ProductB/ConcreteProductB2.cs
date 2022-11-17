using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete.ProductB
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string FunctionB()
        {
            return "Result B2";
        }

        public string AnotherFunctionB(IAbstractProductA productA)
        {
            var result = productA.FunctionA();

            return $"Result B2 with {result}";
        }
    }
}
