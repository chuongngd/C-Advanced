using System;

namespace PropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //GetterAndSetter getterAndSetter = new GetterAndSetter();
            //getterAndSetter.getterAndSetterMain();
            //OverrideProperty.OverridePropertyMain // Create an instance of a Cup of Coffee Class
            bool i = false;
            CupOfCoffee myCup = new CupOfCoffee(i);

            Console.WriteLine("myCup's instant value is:" + myCup.Instant);

            // let's change the value of Instant
            myCup.Instant = true;
            Console.WriteLine("myCup's instant value is:" + myCup.Instant);


        }
    }
}
