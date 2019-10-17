using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public class Vintage :AbstractRoadBike
    {
        public override decimal Price { get; } = 600.00m;

        public Vintage(BikeColor color, IWheel wheel)
            : base(color, wheel) { }

        public Vintage(IWheel wheel)
            : this(BikeColor.White, wheel) { }
    } // end class
} // end namespace
