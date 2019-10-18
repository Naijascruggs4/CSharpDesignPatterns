using System;
using System.Collections.Generic;
using System.Text;
using CSharpDesignPatterns.Base;

namespace CSharpDesignPatterns.Builder
{
    public class MountainBikeBuilder : AbstractBikeBuilder
    {
        private AbstractMountainBike _mountainBikeInProgress;

        public override IBicycle Bicycle
        { get{ return _mountainBikeInProgress; } }

        public MountainBikeBuilder(AbstractMountainBike bike)
        {
            this._mountainBikeInProgress = bike;
        } // end constructor

        public override void BuildWideTires()
        {
            Console.WriteLine("Building MountainBike Wide Tires");
        } // end method build wide tires

        public override void BuildHandBars()
        {
            Console.WriteLine("Building MountainBike Handle Bars");
        } // end method build handle bars
    } // end class
} // end namespace
