using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public interface IBicycle
    {
        IWheel GetWheel { get; }

        BikeColor ColorType { get; }

        decimal Price { get; }

        void Paint(BikeColor color);

        void CleanFrame();
        void AirTires();
        void TestRide();
    } // end method IBicycle
} // end namespace
