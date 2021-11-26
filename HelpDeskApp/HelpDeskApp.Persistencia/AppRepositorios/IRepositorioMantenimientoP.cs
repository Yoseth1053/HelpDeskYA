using System.Collections.Generic;
using HelpDeskApp.Dominio;


namespace HelpDeskApp.Persistencia
{
    public interface IRepositorioMantenimientoP
    {
        IEnumerable<MantenimientoP> GetAllMantenimientosP();
        MantenimientoP AddMantenimientoP(MantenimientoP mantenimientoP);
    }
}