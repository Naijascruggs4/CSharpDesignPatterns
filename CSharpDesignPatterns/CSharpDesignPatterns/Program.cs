using CSharpDesignPatterns.AbstractFactory;
using CSharpDesignPatterns.Adapter;
using CSharpDesignPatterns.Base;
using CSharpDesignPatterns.Builder;
using CSharpDesignPatterns.Decorator;
using CSharpDesignPatterns.Facade;
using CSharpDesignPatterns.Singleton;
using System;
using System.Collections.Generic;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //AbstractFactoryDemo();
            //BuilderPatternDemo();
            //SingletonPatternDemo();
            //AdapterPatternDemo();
            //DecoratorPatternDemo();
            FacadePatternDemo();
        } // end method main

        static void FacadePatternDemo()
        {
            BikeFacade facade = new BikeFacade();
            facade.PrepareForSale(new Vintage(BikeColor.White, new NarrowWheel(20)));
        } // end facade pattern demo

        static void DecoratorPatternDemo()
        {
            IBicycle myMountainBike = new CrossCountry(new WideWheel(30));
            Console.WriteLine(myMountainBike);

            myMountainBike = new CustomGripOption(myMountainBike);
            Console.WriteLine(myMountainBike);

            myMountainBike = new LeatherSeatOption(myMountainBike);
            Console.WriteLine(myMountainBike);
        } // end method decorator pattern demo

        static void AdapterPatternDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new WideWheel(20));
            wheels.Add(new NarrowWheel(26));
            wheels.Add(new UltraWheelAdapter(new UltraWheel(28)));

            foreach (IWheel wheel in wheels)
            {
                Console.WriteLine(wheel);
            } // end for each
        } // end method adapter pattern Demo

        static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("next serial "+generator.NextSerial);
            Console.WriteLine("next serial "+SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial "+generator.NextSerial);
        } // end singleton pattern demo

        static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new DownHill(BikeColor.Black,
                new WideWheel(24));
            AbstractBikeBuilder builder = new MountainBikeBuilder(mountainBike);
            AbstractBikeDirector director = new MountainBikeDirector();

            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        } // end method builder pattern demo

        static void AbstractFactoryDemo()
        {
            AbstractBikeFactory factory = new RoadBikeFactory();
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        } // end method abstract factory demo

    } // end class
} // end namespace
