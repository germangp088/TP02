using System;

namespace EJ01
{
    class Cuadrado : FiguraGeometrica
    {
        private double lado;
        public Cuadrado(double lado) {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return Math.Pow(lado, 2);
        }

        public double CalcularPerimetro()
        {
            return lado * 4;
        }
    }
}
