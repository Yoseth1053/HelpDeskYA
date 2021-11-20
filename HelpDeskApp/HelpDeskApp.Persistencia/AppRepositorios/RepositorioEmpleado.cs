using System.Collections.Generic;
using System.Linq;
using HelpDeskApp.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskApp.Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        private readonly AppContext _appContext = new AppContext();

        Empleado IRepositorioEmpleado.AddEmpleado(Empleado empleado)
        {
            var empleadoAdicionado = _appContext.Empleados.Add(empleado);
            _appContext.SaveChanges();
            return empleadoAdicionado.Entity;
        }
        IEnumerable<Empleado> IRepositorioEmpleado.GetAllEmpleados()
        {
            return _appContext.Empleados;
        }
    }
}