using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rueda rueda1 = new Rueda(1.5);
            Rueda rueda2 = new Rueda(2.5);
            Rueda rueda3 = new Rueda(3.5);
            Motor motor1 = new Motor(16.4);
            Motor motor2 = new Motor(18.4);
            Motor motor3 = new Motor(26.4);
            CajaDeCambios cajaDeCambios1 = new CajaDeCambios(Tipo.Manual, 5);
            CajaDeCambios cajaDeCambios2 = new CajaDeCambios(Tipo.Automatica, 6);
            CajaDeCambios cajaDeCambios3 = new CajaDeCambios(Tipo.Automatica, 5);
            Auto auto1 = new Auto(motor2, cajaDeCambios1);
            Auto auto2 = new Auto(motor1, cajaDeCambios3);
            Auto auto3 = new Auto(motor1, cajaDeCambios2);
            for (int i = 0; i < 4; i++)
            {
                auto1.AgregaRueda(rueda1);
            }
            for (int i = 0; i < 5; i++)
            {
                auto2.AgregaRueda(rueda3);
            }
            for (int i = 0; i < 7; i++)
            {
                auto3.AgregaRueda(rueda1);
            }
            Console.WriteLine();
            Console.WriteLine(auto1.ToString());
            Console.WriteLine(auto2.ToString());
            Console.WriteLine(auto3.ToString());
            Console.Read();
        }
    }
}
