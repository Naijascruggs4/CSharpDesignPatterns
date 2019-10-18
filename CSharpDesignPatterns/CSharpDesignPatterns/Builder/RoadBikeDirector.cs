using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Builder
{
    public class RoadBikeDirector : AbstractBikeDirector
    {
        public override IBicycle Build(AbstractBikeBuilder builder)
        {
            builder.BuildHandBars();
            builder.BuildStreetTires();
            return builder.Bicycle;
        }
    } // end class
} // end namespace
