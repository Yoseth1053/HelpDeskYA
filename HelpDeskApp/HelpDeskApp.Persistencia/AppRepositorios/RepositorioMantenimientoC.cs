using System.Collections.Generic;
using System.Linq;
using HelpDeskApp.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskApp.Persistencia
{
    public class RepositorioMantenimientoC : IRepositorioMantenimientoC
    {
        private readonly AppContext _appContext = new AppContext();

        MantenimientoC IRepositorioMantenimientoC.AddMantenimientoC(MantenimientoC mantenimientoC)
        {
            var mantenimientoCAdicionado = _appContext.MantenimientosC.Add(mantenimientoC);
            _appContext.SaveChanges();
            return mantenimientoCAdicionado.Entity;
        }
        IEnumerable<MantenimientoC> IRepositorioMantenimientoC.GetAllMantenimientosC()
        {
            return _appContext.MantenimientosC;
        }
    }
    
        
}