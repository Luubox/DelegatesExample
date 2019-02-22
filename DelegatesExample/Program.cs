using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath.MathOperation mathOp;

            mathOp = MyMath.Multiply;
            Console.WriteLine(mathOp(3, 4));

            mathOp = (a, b) => { return a + b; };
            Console.WriteLine(mathOp(3, 4));
        }
    }
}
