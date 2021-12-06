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

        void IRepositorioEmpleado.DeleteEmpleado(int idEmpleado)
        {
            var empleadoEncontrado = _appContext.Empleados.Find(idEmpleado);
            if (empleadoEncontrado == null)
                return;
            _appContext.Empleados.Remove(empleadoEncontrado);
            _appContext.SaveChanges();
        }
        Empleado IRepositorioEmpleado.GetEmpleado(int idEmpleado)
        {
            return _appContext.Empleados.Find(idEmpleado);
        }
        Empleado IRepositorioEmpleado.UpdateEmpleado(Empleado empleado)
        {
            var empleadoEncontrado = _appContext.Empleados.Find(empleado.Id);
            if (empleadoEncontrado != null)
            {
                
                empleadoEncontrado.EmpDocumento = empleado.EmpDocumento;
                empleadoEncontrado.EmpNombres = empleado.EmpNombres;
                empleadoEncontrado.EmpApellidos = empleado.EmpApellidos;
                empleadoEncontrado.EmpCelular = empleado.EmpCelular;
                empleadoEncontrado.EmpCorreo = empleado.EmpCorreo;
                empleadoEncontrado.TipoEmpleado = empleado.TipoEmpleado;
                            
                _appContext.SaveChanges();
            }
            return empleadoEncontrado;
        }

    }
}