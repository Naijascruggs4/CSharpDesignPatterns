using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Singleton
{
    public class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;

        private static object synchronizationRoot = new object();

        private int _count = 12345;

        public static SerialNumberGenerator Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(synchronizationRoot)
                    {
                        if(instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        } // end if
                    } // end lock
                } // end if
                return instance;
            } // end  get     
        } // end instance

        private SerialNumberGenerator() { }

        public int NextSerial { get { return ++_count; } }

    } // end class
} // end namespace
