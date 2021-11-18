using System;

namespace HelpDeskApp.Dominio
{
    public class MantenimientoCorrectivo
    {
        public int Id {get ; set;}
        public Incidentes Incidentes {get ; set;}
        public Ambiente Ambiente {get ; set;}
        public DateTime ManFechaSolucion {get ; set;}
        public string ManDescripcion {get ; set;}
  

    }
}