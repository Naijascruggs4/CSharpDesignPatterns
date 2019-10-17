using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.AbstractFactory
{
    public class MountainSeat : IBikeSeat
    {
        public string BikeSeatParts
        {
            get { return "Seat parts for the Mountain Bike"; }
        } // end method bike seat parts
    } // end class
} // end namespace
