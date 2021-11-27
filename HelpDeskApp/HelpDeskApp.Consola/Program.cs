using System;
using System.Collections.Generic;
using HelpDeskApp.Dominio;
using HelpDeskApp.Persistencia;

namespace HelpDeskApp.Consola
{
    class Program
    {

        private static IRepositorioEmpleado _repoEmpleado = new RepositorioEmpleado();
        private static IRepositorioAmbiente _repoAmbiente = new RepositorioAmbiente();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddEmpleado();
            //BuscarEmpleado();
            //MostrarEmpleados();
            //AddAmbiente();
            //BuscarAmbiente();
            MostrarAmbientes();

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
        private static void AddAmbiente()
        {
            var ambiente = new Ambiente
            {
                
                AmbNombre = "Electronica",
                AmbUbicacion = "Automatizacion"
            };
            _repoAmbiente.AddAmbiente(ambiente);
        }
        
        private static void BuscarAmbiente(int idAmbiente)
        {
            var ambiente = _repoAmbiente.GetAmbiente(idAmbiente);
            Console.WriteLine(ambiente.AmbNombre+" "+ambiente.AmbUbicacion);
        }
        
        private static void MostrarAmbientes()
        {
            IEnumerable<Ambiente> ambientes = _repoAmbiente.GetAllAmbientes();
            foreach (var ambiente in ambientes)
            {
                Console.WriteLine(ambiente.AmbNombre + " " + ambiente.AmbUbicacion);
            }
        }

        private static void EliminarAmbiente(int idAmbiente)
        {
            _repoAmbiente.DeleteAmbiente(idAmbiente);
            Console.WriteLine("ambiente Eliminado");
        }

    }
}
