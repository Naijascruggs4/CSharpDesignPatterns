using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Adapter
{
    public class UltraWheel
    {
        public int WheelSize { get; private set; }

        public UltraWheel(int size)
        {
            WheelSize = size;
        }

        public override string ToString()
        {
            return "ULTRAWHEEL " + WheelSize;
        } // end string
    } // end class
} // end namesapce
