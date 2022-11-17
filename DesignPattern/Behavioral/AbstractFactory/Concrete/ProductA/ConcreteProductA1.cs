using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete.ProductA
{
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string FunctionA()
        {
            return "result A1";
        }
    }
}
