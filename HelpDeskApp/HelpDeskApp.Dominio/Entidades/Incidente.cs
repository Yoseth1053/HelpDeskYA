using System;

namespace HelpDeskApp.Dominio
{
    public class Incidente
    {
        public int Id {get ; set;}
        public string IncDescripcion {get ; set;}
        public string IncEstado {get ; set;}
        public DateTime IncFechaReporte {get ; set;}
        public DateTime IncFechaAtencion {get ; set;}
        public string EmpDocumento {get ; set;}

    }
}