using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Tutorial_Teacher
{
    internal class Class_C
    {
        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }
        //programist 2 pravyat CubeRoot
        //...

        //Programist 1 pravyat Babylon
        public double BabylonSqrt(double number)
        {
            double guess = number / 2;
            while (Math.Abs(guess * guess - number) < 0.01) {
                double other = number / guess;
                guess = (guess+other)/2;
            }
            return guess;
        }
    }
}
