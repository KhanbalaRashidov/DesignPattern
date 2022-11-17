using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Abstract;

namespace Builder.Concrete
{
    public class ConcreteBuilder:IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }
        public void BuildA()
        {
            this._product.Add("ProductA1");
        }

        public void BuildB()
        {
            this._product.Add("ProductB1");
        }

        public void BuildC()
        {
            this._product.Add("ProductC1");
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public Product GetProduct()
        {
            Product result = this._product;
            this.Reset();

            return result;
        }
    }
}
