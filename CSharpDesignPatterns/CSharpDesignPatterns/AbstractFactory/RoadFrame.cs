using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.AbstractFactory
{
    public class RoadFrame : IBikeFrame
    {
        public string BikeFrameParts
        {
            get { return "Frame parts for the Road Bike"; }  

        } // end method bike frame parts
    } // end class
} // end namespace
