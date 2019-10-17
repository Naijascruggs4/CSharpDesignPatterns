using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public class WideWheel : AbstractWheel
    {
        public WideWheel(int size)
            : base(size, true) { }
    } // end class
} // end namespace
