using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public class CrossCountry : AbstractMountainBike
    {
        public override decimal Price { get; } = 850.00m;

        public CrossCountry(BikeColor color, IWheel wheel)
            : base(color, wheel) { }

        public CrossCountry(IWheel wheel)
            : this(BikeColor.Burnt_Orange, wheel) { }

    } // end class
} // end namespace
