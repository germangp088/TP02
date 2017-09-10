using System;

namespace EJ01
{
    class Circulo : FiguraGeometrica
    {
        private double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
