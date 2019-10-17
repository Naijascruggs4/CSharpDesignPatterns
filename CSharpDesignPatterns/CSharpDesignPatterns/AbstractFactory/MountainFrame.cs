using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.AbstractFactory
{
    public class MountainFrame : IBikeFrame
    {
        public string BikeFrameParts
        {
            get { return "frame parts for the Mountain Bike."; }
        } // end method bike frame parts
    } // end class
} // end namespace
