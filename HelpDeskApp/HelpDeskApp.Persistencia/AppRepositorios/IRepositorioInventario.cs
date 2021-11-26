using System.Collections.Generic;
using HelpDeskApp.Dominio;

namespace HelpDeskApp.Persistencia
{
    public interface IRepositorioInventario
    {
        IEnumerable<Inventario> GetAllInventarios();
        Inventario AddInventario(Inventario inventario);
    }
}