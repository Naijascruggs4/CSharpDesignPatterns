using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public class DownHill : AbstractMountainBike
    {
        public override decimal Price { get; } = 870.00m;

        public DownHill(BikeColor color, IWheel wheel)
            : base(color, wheel) { }

        public DownHill(IWheel wheel)
            : this(BikeColor.Mint_Green, wheel) { } 

    } // end class
} // end namespace
