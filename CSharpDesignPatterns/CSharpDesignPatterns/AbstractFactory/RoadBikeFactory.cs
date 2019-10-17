using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.AbstractFactory
{
    public class RoadBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrame CreateBikeFrame()
        {
            return new RoadFrame();
        } // end method create bike frame
        public override IBikeSeat CreateBikeSeat()
        {
            return new RoadSeat();
        } // end method create bike seat
    } // end class
} // end namespace 
