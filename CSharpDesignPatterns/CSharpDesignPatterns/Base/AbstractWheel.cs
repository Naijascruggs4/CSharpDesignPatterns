using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public abstract class AbstractWheel : IWheel
    {
        public int Size { get; }
        public bool IsWide { get; }
        public AbstractWheel(int size, bool iswide)
        {
            Size = size;
            IsWide = iswide;
        } // end method abstract wheel

        public override string ToString()
        {
            return this.GetType().Name + " with a wheel size of " +
                Size + " inches";
        } // end method to string
    } // end class
} // end namespace
