using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Abstract
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SameOperation()
        {
            var result = "Creator: run " + FactoryMethod().Operation();

            return result;
        }
    }
}
