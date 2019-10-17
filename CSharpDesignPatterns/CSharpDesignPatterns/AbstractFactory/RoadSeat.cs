using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.AbstractFactory
{
    public class RoadSeat : IBikeSeat
    {
        public string BikeSeatParts
        {
            get { return "Seat parts for the Road Bike"; }
        }
    } // end class
} // end namespace
