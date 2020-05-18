using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionDemo
{
    class Example1
    {
        public  void ExecuteMain()
        {
            Type m1;
            m1 = typeof(int);
            System.Console.WriteLine(m1.Name + " " + m1.FullName);
            m1 = typeof(System.Int32);
            System.Console.WriteLine(m1.Name + " " + m1.FullName);
            m1 = typeof(Example1);
            System.Console.WriteLine(m1.Name + " " + m1.FullName);
        }

        public static void ExecuteMain1()
        {
            Type m1 = typeof(Example1);
            MemberInfo[] n;
            n = m1.GetMembers();
            Console.WriteLine(n.Length);
            foreach(MemberInfo a in n)
            {
                Console.WriteLine(a.Name);
            }
        }

        
    }
}
