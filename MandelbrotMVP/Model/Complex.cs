using System;

namespace MandelbrotMVP.Model
{
    public class Complex
    {
        private double _real, _imaginary;

        public Complex(double real, double imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        // Квадрат
        public void Square()
        {
            double sqr = (_real * _real) - (_imaginary * _imaginary);
            _imaginary = 2.0 * _real * _imaginary;
            _real = sqr;
        }

        // Модуль
        public double Modulus()
        {
            return Math.Sqrt((_real * _real) + (_imaginary * _imaginary));
        }

        // Сложение
        public void Add(Complex complex)
        {
            _real += complex._real;
            _imaginary += complex._imaginary;
        }
    }
}