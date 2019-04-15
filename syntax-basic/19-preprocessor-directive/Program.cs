
#define TEST

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_preprocessor_directive
{
    class Program
    {
        static void Main(string[] args)
        {
            #region branch area
#if (TEST)
            System.Console.WriteLine("TEST enabled");
#else
            System.Console.WriteLine("TEST disabled");
#endif
            #endregion
        }
    }
}
