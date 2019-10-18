using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator
{
    class GoldFrameOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 300.00m; }
        } // end price

        public GoldFrameOption(IBicycle bicycle)
            : base(bicycle) { }
        
    } // end class
} // end namespace
