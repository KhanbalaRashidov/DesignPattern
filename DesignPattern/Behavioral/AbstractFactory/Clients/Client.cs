using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstract.Factory;
using AbstractFactory.Concrete.Factory;

namespace AbstractFactory.Clients
{
    public class Client
    {
        public void Run()
        {
            Console.WriteLine("Client: testing... ");
            ClientMethod(new ConcreteFactory1());

            Console.WriteLine("Client: testing...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.FunctionB());
            Console.WriteLine(productB.AnotherFunctionB(productA));
        }
    }
}
