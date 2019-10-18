using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Adapter
{
    public class UltraWheelAdapter : AbstractWheel 
    {
        public UltraWheelAdapter(UltraWheel ultrawheel)
            :base(ultrawheel.WheelSize, false) { }
    } // end class
} // end namespace
