using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
    class InterfaceIndexer
    {
        interface IIndexers
        {
            string this[int indexerValue] { get; set; }
            //public int print();
        }
        public class IndexerClass : IIndexers
        {
            readonly string[] _nameList = { "AKhil", "Bob", "Shawn", "Sandra" };

            public string this[int indexerValue]
            {
                get
                {
                    return _nameList[indexerValue];
                }
                set
                {
                    _nameList[indexerValue] = value;
                }
            }

            public int print()
            {
                return 0;
            }
        }
      
            public static void InterfaceIndexersMain()
            {
                IIndexers iIndexer = new IndexerClass();
                Console.WriteLine(iIndexer[0]);
                Console.WriteLine(iIndexer[1]);
                Console.WriteLine(iIndexer[2]);
                Console.WriteLine(iIndexer[3]);
                Console.ReadLine();

            }
        


    }
}
