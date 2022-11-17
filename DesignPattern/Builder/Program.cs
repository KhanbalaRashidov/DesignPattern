using Builder.Concrete;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var director = new Director();
            var builder = new ConcreteBuilder();

            director.Builder= builder;


            Console.WriteLine("Minimal product:");
            director.BuildMinimalProduct();
            Console.WriteLine(builder.GetProduct().GetProducts());

            Console.WriteLine("Full product:");
            director.BuildFullProduct();
            Console.WriteLine(builder.GetProduct().GetProducts());

            Console.WriteLine("Custom Product:");
            builder.BuildA();
            builder.BuildC();

            Console.WriteLine(builder.GetProduct().GetProducts());
        }
    }
}