using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_indexer
{
    class Test
    {
        private string name;
        private int[] data = new int[100];

        public int this[int index]
        {
            get
            {
                if((index < 0) || (index >= 100))
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return data[index];
                }
            }
            set
            {
                if((index < 0) || (index >= 100))
                {
                    ;
                }
                else
                {
                    data[index] = value;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t[0] = -1;
            System.Console.WriteLine(t[0].ToString());
        }
    }
}
