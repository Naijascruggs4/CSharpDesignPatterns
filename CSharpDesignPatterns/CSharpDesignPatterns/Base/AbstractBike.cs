using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Base
{
    public abstract class AbstractBike : IBicycle
    {
        public IWheel GetWheel { get; }
        public BikeColor ColorType { get; private set; }
        public abstract decimal Price { get; }
        public AbstractBike(BikeColor color, IWheel wheel)
        {
            ColorType = color;
            GetWheel = wheel;
        } // end method abstract bike

        public AbstractBike(IWheel wheel)
            : this(BikeColor.Chrome, wheel) { }

        public virtual void Paint(BikeColor color)
        {
            ColorType = color;
        } // end method paint
        
        public void CleanFrame()
        {
            Console.WriteLine("Cleaning Frame...");
        } // end clean frame

        public virtual void AirTires()
        {
            Console.WriteLine("Airing up tires...");
        } // end air tires

        public virtual void TestRide()
        {
            Console.WriteLine("Taking the bike for a test ride...");
        } // end test ride

        public override string ToString()
        {
            return this.GetType().Name + " Bicycle color is " + ColorType + 
                " and costs $" + Price;
        } // end string
    } // end class
} // end namespace
