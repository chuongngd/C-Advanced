using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
    interface InterfaceProperty
    {
        //properties go here
        bool Instant
        {
            get;
            set;
        }
        void AddSugar();
    }
    public class CupOfCoffee : InterfaceProperty
    {
        private bool instant;

        public CupOfCoffee(bool i)
        {
            instant = i;
        }

        // Property implementation:
        public bool Instant
        {
            get
            {
                return instant;
            }

            set
            {
                instant = value;
            }
        }
        public void AddSugar()
        {
            Console.WriteLine("Adding Suggar!");
        }
    }




}
