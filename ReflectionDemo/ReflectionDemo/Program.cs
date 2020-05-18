using System;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Example1 ex = new Example1();
            ex.ExecuteMain();
            Example1.ExecuteMain1();
            Example2.ExecuteMain();
        }
    }
    class Example2
    {
        public static void ExecuteMain()
        {
            Type m;
            m = typeof(nclass);
            System.Console.WriteLine(m.Name);
            foreach (object a in m.GetCustomAttributes(true))
                Console.WriteLine(a);
            foreach(MethodInfo a in m.GetMethods())
            {
                object[] b = a.GetCustomAttributes(true);
                foreach(Attribute c in b)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    class chuong: System.Attribute
    {
        string s1, s2; int i1;
        public int ntest;
        public chuong(string s, int i) {
            s1 = s; i1 = i;
        }
        public string name
        {
            get { return s2; }
            set {s2 = value; }
        }

    }
    [chuong("ho", 1, name ="bye", ntest =100)]
    class nclass
    {
        [chuong("ho2", 1, name = "bye", ntest = 100)]

        public void abc() { }
        public int i;
        public void pqr() { }
    }
}
