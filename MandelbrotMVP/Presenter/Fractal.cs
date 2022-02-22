using System;
using MandelbrotMVP.Model;
using MandelbrotMVP.View;

namespace MandelbrotMVP.Presenter
{
    class Fractal
    {
        public double X0 { get; set; }
        public double XN { get; set; }
        public double Y0 { get; set; }
        public double YN { get; set; }

        private readonly IMandelbrot _mandelbrotView;

        public Fractal(IMandelbrot mandelbrotView)
        {
            _mandelbrotView = mandelbrotView;
        }

        private void UpdateView()
        {
            if (
                _mandelbrotView.TxtX0 == ""
                || _mandelbrotView.TxtXN == ""
                || _mandelbrotView.TxtY0 == ""
                || _mandelbrotView.TxtYN == ""
                )
            {
                SetDefaultParams();
            }
            else
            {
                XN = Convert.ToDouble(_mandelbrotView.TxtXN);
                X0 = Convert.ToDouble(_mandelbrotView.TxtX0);
                YN = Convert.ToDouble(_mandelbrotView.TxtYN);
                Y0 = Convert.ToDouble(_mandelbrotView.TxtY0);
            }
        }

        // Параметры по умолчанию
        private void SetDefaultParams()
        {
            XN = 2.0;
            X0 = 4.0;
            Y0 = 4.0;
            YN = 4.0;
        }

        public void Draw(MainWindow window)
        {
            UpdateView();

            System.Drawing.Bitmap image = new System.Drawing.Bitmap
                (
                    window.pbCanvas.Width, 
                    window.pbCanvas.Height
                );

            for (int x = 0; x < window.pbCanvas.Width; ++x)
            {
                for (int y = 0; y < window.pbCanvas.Height; ++y)
                {
                    double real = (double)(x - (window.pbCanvas.Width / XN)) / (double)(window.pbCanvas.Width / YN);
                    double imaginary = (double)(y - (window.pbCanvas.Width / X0)) / (double)(window.pbCanvas.Width / Y0);

                    Complex complex = new Complex(real, imaginary);
                    Complex zero = new Complex(0, 0);

                    int iter = 0;
                    do
                    {
                        ++iter;
                        zero.Square();
                        zero.Add(complex);

                        if (zero.Modulus() > 2.0)
                            break;
                    }
                    while (iter < 100);

                    image.SetPixel
                        (
                            x, y, iter < 100
                            ? System.Drawing.Color.FromArgb(iter, iter, iter)
                            : System.Drawing.Color.FromArgb(255, 255, 255)
                        );
                }
            }
            window.pbCanvas.Image = image;
        }
    }
}