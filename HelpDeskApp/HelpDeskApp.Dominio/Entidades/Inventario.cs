namespace HelpDeskApp.Dominio
{
    public class Inventario
    {
        public int Id {get ; set;}
        public string InCantidad {get ; set;}
        public TipoElemento TipoElemento {get ; set;}
        public Ambiente Ambiente{get ; set;}

    }
}