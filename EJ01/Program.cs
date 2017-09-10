using System;

namespace EJ01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado(4.8);
            Console.WriteLine("Perimero del cuadrado:" + cuadrado.CalcularPerimetro());
            Console.WriteLine("Area del cuadrado:" + cuadrado.CalcularArea());

            Circulo circulo = new Circulo(6.7);
            Console.WriteLine("Perimero del circulo:" + circulo.CalcularPerimetro());
            Console.WriteLine("Area del circulo:" + circulo.CalcularArea());

            Triangulo triangulo = new Triangulo(6, 7, 10, 10);
            Console.WriteLine("Perimero del triangulo:" + triangulo.CalcularPerimetro());
            Console.WriteLine("Area del triangulo:" + triangulo.CalcularArea());
            Console.Read();
        }
    }
}
