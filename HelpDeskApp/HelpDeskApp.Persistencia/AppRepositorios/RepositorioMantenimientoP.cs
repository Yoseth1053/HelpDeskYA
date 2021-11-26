using System.Collections.Generic;
using System.Linq;
using HelpDeskApp.Dominio;
using Microsoft.EntityFrameworkCore;


namespace HelpDeskApp.Persistencia
{
    public class RepositorioMantenimientoP : IRepositorioMantenimientoP
    {
        private readonly AppContext _appContext = new AppContext();

        MantenimientoP IRepositorioMantenimientoP.AddMantenimientoP(MantenimientoP mantenimientoP)
        {
            var mantenimientoPAdicionado = _appContext.MantenimientosP.Add(mantenimientoP);
            _appContext.SaveChanges();
            return mantenimientoPAdicionado.Entity;
        }
        IEnumerable<MantenimientoP> IRepositorioMantenimientoP.GetAllMantenimientosP()
        {
            return _appContext.MantenimientosP;
        }
    }
    
}
