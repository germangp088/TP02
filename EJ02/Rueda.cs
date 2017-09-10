using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    class Rueda: IFunctionality
    {
        private double diametro;
        public Rueda(double diametro)
        {
            this.diametro = diametro;
        }

        public void frenar()
        {
            throw new NotImplementedException();
        }

        public void iniciar()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Las Ruedas tienen un diametro de " + diametro;
        }
    }
}
