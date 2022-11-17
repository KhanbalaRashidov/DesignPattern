using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Abstract;

namespace Builder.Concrete
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalProduct()
        {
            this._builder.BuildA();
        }

        public void BuildFullProduct()
        {
            this._builder.BuildA();
            this._builder.BuildB();
            this._builder.BuildC();
        }
    }
}
