using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PropertyDemo
{
    class Readonly
    {
        public int ff { get; private set; }

        public static void ReadonlyMain()
        {
            Readonly a = new Readonly();

            int gg = a.ff + 9;

            System.Console.WriteLine(gg);
            Console.WriteLine("Hello World!");
        }

    }
}
