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
         void IRepositorioIncidente.DeleteIncidente(int idIncidente)
        {
            var incidenteEncontrado = _appContext.Incidentes.Find(idIncidente);
            if (incidenteEncontrado == null)
                return;
            _appContext.Incidentes.Remove(incidenteEncontrado);
            _appContext.SaveChanges();
        }
        Incidente IRepositorioIncidente.GetIncidente(int idIncidente)
        {
            return _appContext.Incidentes.Find(idIncidente);
        }
        Incidente IRepositorioIncidente.UpdateIncidente(Incidente incidente)
        {
            var incidenteEncontrado = _appContext.Incidentes.Find(incidente.Id);
            if (incidenteEncontrado != null)
            {
                
                incidenteEncontrado.IncDescripcion = incidente.IncDescripcion;
                incidenteEncontrado.IncEstado = incidente.IncEstado;
                incidenteEncontrado.IncFechaReporte = incidente.IncFechaReporte;
                incidenteEncontrado.IncFechaAtencion = incidente.IncFechaAtencion;
                incidenteEncontrado.EmpDocumento = incidente.EmpDocumento;
                _appContext.SaveChanges();
            }
            return incidenteEncontrado;
        }

    }

        
    }