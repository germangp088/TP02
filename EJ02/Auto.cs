using System;
using System.Collections.Generic;
using System.Text;

namespace EJ02
{
    class Auto
    {
        private List<Rueda> ruedas = new List<Rueda>();
        private Motor motor;
        private CajaDeCambios cajaDeCambios;
        public Auto(Motor motor, CajaDeCambios cajaDeCambios)
        {
            this.motor = motor;
            this.cajaDeCambios = cajaDeCambios;
        }
        public void AgregaRueda(Rueda rueda)
        {
            if (ruedas.Count == 5)
            {
                Console.WriteLine("El auto no puede tener mas de 5 ruedas");
            }
            else
            {
                ruedas.Add(rueda);
            }
        }

        
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(motor.ToString());
            str.AppendLine(cajaDeCambios.ToString());
            str.AppendLine(ruedas[0].ToString());
            return str.ToString();
        }
    }
}
