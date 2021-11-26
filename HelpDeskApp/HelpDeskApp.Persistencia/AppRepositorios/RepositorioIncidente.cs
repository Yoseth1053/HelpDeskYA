using System.Collections.Generic;
using System.Linq;
using HelpDeskApp.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskApp.Persistencia
{
    public class RepositorioIncidente : IRepositorioIncidente
    {
        private readonly AppContext _appContext = new AppContext();

        Incidente IRepositorioIncidente.AddIncidente(Incidente incidente)
        {
            var incidenteAdicionado = _appContext.Incidentes.Add(incidente);
            _appContext.SaveChanges();
            return incidenteAdicionado.Entity;
        }
        IEnumerable<Incidente> IRepositorioIncidente.GetAllIncidentes()
        {
            return _appContext.Incidentes;
        }
    }
        
    }