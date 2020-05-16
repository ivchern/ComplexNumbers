using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbers
{
    class Complex
    {
        private double realNumber;
        private double imaginaryNumber;
        public Complex(double realNumber, double imaginaryNumber)
        {
            this.realNumber = realNumber;
            this.imaginaryNumber = imaginaryNumber;
        }
        public Complex Plus(Complex complex)
        {
            double sumReal = complex.realNumber + realNumber;
            double sumImaginary = complex.imaginaryNumber + imaginaryNumber;
            Complex newComplex = new Complex(sumReal, sumImaginary);
            return newComplex;

        }
        public Complex Minus(Complex complex)
        {
            double minusReal = complex.realNumber - realNumber;
            double minusImaginary = complex.imaginaryNumber - imaginaryNumber;
            Complex newComplex = new Complex(minusReal, minusImaginary);
            return newComplex;
        }
        static public void Print(Complex complex)
        {
            Console.WriteLine($"Вещественное: {complex.realNumber}, Мнимое: {complex.imaginaryNumber}");
        }

    }
}
