using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator
{
    public class CustomGripOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 20.00m; }
        } // end price

        public CustomGripOption(IBicycle bicycle)
            : base(bicycle) { }
    } // end class
} // end namespace
