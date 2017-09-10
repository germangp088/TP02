using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    class Motor : IFunctionality
    {
        double cilindrada;
        public Motor(double cilindrada)
        {
            this.cilindrada = cilindrada;
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
            return "El motor tiene un cilindrado de " + cilindrada;
        }
    }
}
