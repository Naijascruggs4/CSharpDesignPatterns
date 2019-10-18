using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Facade
{
    public class Registration
    {
        private IBicycle _bicycle;

        public Registration(IBicycle bike)
        {
            this._bicycle = bike;
        } // end registration

        public void AllocateBikeNumber()
        {
            Console.WriteLine("Allocating Bike Number");
        } // end allocate bike number
    } // end class
} // end namespace
