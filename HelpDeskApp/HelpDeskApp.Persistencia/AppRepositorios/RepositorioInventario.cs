using System.Collections.Generic;
using System.Linq;
using HelpDeskApp.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskApp.Persistencia
{
    public class RepositorioInventario : IRepositorioInventario
    {
        private readonly AppContext _appContext = new AppContext();

        Inventario IRepositorioInventario.AddInventario(Inventario inventario)
        {
            var inventarioAdicionado = _appContext.Inventarios.Add(inventario);
            _appContext.SaveChanges();
            return inventarioAdicionado.Entity;
        }
        IEnumerable<Inventario> IRepositorioInventario.GetAllInventarios()
        {
            return _appContext.Inventarios;
        }
    }
    
        
    }
