using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public class Complex
    {
        public double Imaginary
        {
            get;
            private set;
        }
        public double Real
        {
            get;
            private set;
        }

        public Complex (double imaginari, double real)
        {
            Imaginary = imaginari;
            Real = real;
        }

        private Complex()   
        {
        }

        public Complex Plus(Complex other)
        {
            var complex = new Complex();
            complex.Imaginary = other.Imaginary + Imaginary;
            complex.Real = other.Real + Real;
            return complex;
        }

        public Complex Minus(Complex other)
        {
            var complex = new Complex();
            complex.Imaginary = other.Imaginary - Imaginary;
            complex.Real = other.Real - Real;
            return complex;
        }
    }
}
