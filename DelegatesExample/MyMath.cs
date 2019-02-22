using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class MyMath
    {
        public delegate int MathOperation(int a, int b);

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
