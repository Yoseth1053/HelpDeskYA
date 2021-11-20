using System;
using System.Collections.Generic;
using HelpDeskApp.Dominio;
using HelpDeskApp.Persistencia;

namespace HelpDeskApp.Consola
{
    class Program
    {

        private static IRepositorioEmpleado _repoEmpleado = new RepositorioEmpleado();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddEmpleado();
            //BuscarEmpleado();
            MostrarEmpleados();
        }
        private static void AddEmpleado()
        {
            var empleado = new Empleado
            {
                EmpDocumento = "10563346",
                EmpNombres = "Pepito",
                EmpApellidos = "Perez",
                EmpCelular = "3001645",
                EmpCorreo = "pepito@gmail.com",
                TipoEmpleado = TipoEmpleado.Administrativo
            };
            _repoEmpleado.AddEmpleado(empleado);
        }
        private static void MostrarEmpleados()
        {
            IEnumerable<Empleado> empleados = _repoEmpleado.GetAllEmpleados();
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado.EmpNombres + " " + empleado.EmpApellidos);
            }
        }
    }
}
