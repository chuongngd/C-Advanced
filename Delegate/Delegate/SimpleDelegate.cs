using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class SimpleDelegate
    {
        //Define a Delegate
        delegate void SumDelegate(int x, int y);

       
            public static void ExecuteMain()
            {
                //Declare Delegate Object
                SumDelegate objDelegate = null;

                //Point to method reference in our example "Sum"
                objDelegate = Sum;

                //Final Step Invoke Delegate
                objDelegate.Invoke(10, 20);
                Console.Read();
            }
            static void Sum(int x, int y)
            {
                Console.WriteLine((x + y).ToString());
            }
        
    }

    public delegate int MyDelagate(int a, int b); //delegates having same signature as method 

    public class Example
    {
        // methods to be assigned and called by delegate
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Difference(int a, int b)
        {
            return a - b;
        }
    }
    class SingleCast
    {
        public static void ExecuteMain()
        {
            Example obj = new Example();

            // 2. Instantiation : As a single cast delegate
            MyDelagate sum = new MyDelagate(obj.Sum);
            MyDelagate diff = new MyDelagate(obj.Difference);

            // 3.Invocation
            Console.WriteLine("Sum of two integer is = " + sum(10, 20));
            Console.WriteLine(obj.Sum(10, 20));
            Console.WriteLine("Difference of two integer is = " + diff(20, 10));
            
            Console.WriteLine(obj.Difference(10, 20));
        }
    }
}
