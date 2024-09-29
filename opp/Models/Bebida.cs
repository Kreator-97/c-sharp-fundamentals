namespace opp.Models
{
    class Bebida
    {
        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public void Beberse(int cantidad)
        {
            Cantidad -= cantidad;
        }
    }
}
