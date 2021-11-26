using System;

namespace HelpDeskApp.Dominio
{
    public class MantenimientoP
    {
         public int Id {get ; set;}
         public Ambiente Ambiente {get ; set;}
         public DateTime ManPFecha {get ; set;}
         public string ManPDescripcion {get ; set;}
    }
}