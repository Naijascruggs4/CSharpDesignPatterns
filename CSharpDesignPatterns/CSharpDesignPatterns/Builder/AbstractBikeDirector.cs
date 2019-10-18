using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Builder
{
    public abstract class AbstractBikeDirector
    {
        public abstract IBicycle Build(AbstractBikeBuilder builder);
    } // end class
} // end namespace
