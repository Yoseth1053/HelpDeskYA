using System.Collections.Generic;
using HelpDeskApp.Dominio;

namespace HelpDeskApp.Persistencia
{
    public interface IRepositorioMantenimientoC
    {
        IEnumerable<MantenimientoC> GetAllMantenimientosC();
        MantenimientoC AddMantenimientoC(MantenimientoC mantenimientoC);
    }
}