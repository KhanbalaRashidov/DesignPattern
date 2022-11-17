using FactoryMethod.Clients;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            new Client().Run();
        }
    }
}