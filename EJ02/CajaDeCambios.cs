namespace EJ02
{
    class CajaDeCambios
    {
        Tipo tipo;
        int cantidadCambios;
        public CajaDeCambios(Tipo tipo, int cantidadCambios)
        {
            this.tipo = tipo;
            this.cantidadCambios = cantidadCambios;
        }

        public override string ToString()
        {
            return "La caja de cambios es " + tipo.ToString() + " con una cantidad de cambios de " + cantidadCambios;
        }
    }
}
