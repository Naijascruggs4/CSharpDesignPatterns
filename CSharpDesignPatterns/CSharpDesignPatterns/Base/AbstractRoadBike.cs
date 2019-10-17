using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public abstract class AbstractRoadBike : AbstractBike 
    {
        public override decimal Price { get; } = 540.00m;

        public AbstractRoadBike(BikeColor color, IWheel wheel)
            : base(color, wheel) { }

        public AbstractRoadBike(IWheel wheel)
            : this(BikeColor.Chrome, wheel) { }
    } // end class
} // end namespace
