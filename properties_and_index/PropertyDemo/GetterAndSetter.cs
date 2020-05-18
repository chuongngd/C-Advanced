using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
  
    class GetterAndSetter
    {
        static int f1 = 0;
        public static int ff {
            get
            {
                return f1;
            }
            set
            {
                f1 = value;
            }
        }

        public void getterAndSetterMain()
        {
            GetterAndSetter.ff = 100;
            Console.WriteLine(f1);
        }
    }
}
