using AbstractFactory.Clients;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            new  Client().Run();
        }
    }
}