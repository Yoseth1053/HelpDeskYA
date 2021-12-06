using System.Collections.Generic;
using HelpDeskApp.Dominio;

namespace HelpDeskApp.Persistencia
{
    public interface IRepositorioIncidente
    {
        IEnumerable<Incidente> GetAllIncidentes();
        Incidente AddIncidente(Incidente incidente);
        Incidente UpdateIncidente(Incidente incidente);
        void DeleteIncidente(int idIncidente);    
        Incidente GetIncidente(int idIncidente);
    }
}