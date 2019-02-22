using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class MyMath
    {
        //laver en delegate der returnerer en int og tager to int parametre
        public delegate int MathOperation(int a, int b);

        public static int Multiply(int a, int b)
        {
            //returnerer to int parametre ganget med hinanden
            return a * b;
        }
    }
}
