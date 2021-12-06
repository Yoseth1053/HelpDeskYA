using System.Collections.Generic;
using HelpDeskApp.Dominio;

namespace HelpDeskApp.Persistencia
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<Empleado> GetAllEmpleados();
        Empleado AddEmpleado(Empleado empleado);
        Empleado UpdateEmpleado(Empleado empleado);
        void DeleteEmpleado(int idEmpleado);    
        Empleado GetEmpleado(int idEmpleado);
    }
}