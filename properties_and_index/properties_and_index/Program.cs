using System;

namespace properties_and_index
{
    class Program
    {
        getter get;
        public Program()
        {
            get = new getter();
            get.getterMain();
        }
        static void Main(string[] args)
        {
            getter get = new getter();
            get.getterMain();
            Program bob = new Program();
            Console.WriteLine("Hello World!");
        }
    }
}
