using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Builder
{
    public class MountainBikeDirector : AbstractBikeDirector
    {
        public override IBicycle Build(AbstractBikeBuilder builder)
        {
            builder.BuildHandBars();
            builder.BuildWideTires();
            return builder.Bicycle;
        } // end method IBicycle build
    } // end class
} // end namespace
