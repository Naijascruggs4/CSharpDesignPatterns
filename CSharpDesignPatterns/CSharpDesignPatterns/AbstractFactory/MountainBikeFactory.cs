using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.AbstractFactory
{
    public class MountainBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrame CreateBikeFrame()
        {
            return new MountainFrame();
        } // end method create bike frame
        public override IBikeSeat CreateBikeSeat()
        {
            return new MountainSeat();
        } // end method create bike seat 
    } // end class
}   // end namespace
