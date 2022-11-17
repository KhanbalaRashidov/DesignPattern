using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Abstract;
using FactoryMethod.Concrete.ConcreteCreator;

namespace FactoryMethod.Clients
{
    public class Client
    {

        public void Run()
        {

            Console.WriteLine("App run: ConcreteCreator1");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("App run : ConcreteCreator2");
            ClientCode(new ConcreteCreator2());
        }


        public void ClientCode(Creator creator)
        {
            Console.WriteLine($"Client:{creator.SameOperation()}");
        }
    }
}
