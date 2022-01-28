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
        private static IRepositorioIncidente _repoIncidente = new RepositorioIncidente();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddEmpleado();
            //BuscarEmpleado();
            //MostrarEmpleados();
            //AddAmbiente();
            //BuscarAmbiente();
            //MostrarAmbientes();
            //EliminarAmbiente(1);
            //AddIncidente();
            //BuscarIncidente();
            //MostrarIncidentes();
            //EliminarIncidente(1);


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
        private static void BuscarEmpleado(int idEmpleado)
        {
            var empleado = _repoEmpleado.GetEmpleado(idEmpleado);
            Console.WriteLine(empleado.EmpDocumento+" "+empleado.EmpNombres);
        }
        private static void EliminarEmpleado(int idEmpleado)
        {
            _repoEmpleado.DeleteEmpleado(idEmpleado);
            Console.WriteLine("empleado Eliminado");
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


        private static void AddIncidente()
        {
            var incidente = new Incidente
            {
                
                IncDescripcion = "",
                IncEstado = EstadoIncidente.EnProceso,
                IncFechaReporte = new DateTime(2022/08/15),
                IncFechaAtencion = new DateTime(2022/08/15),
                EmpDocumento = ""
            };
            _repoIncidente.AddIncidente(incidente);
        }
        
        private static void BuscarIncidente(int idIncidente)
        {
            var incidente = _repoIncidente.GetIncidente(idIncidente);
            Console.WriteLine(incidente.IncDescripcion+" "+incidente.IncEstado);
        }
        
        private static void MostrarIncidentes()
        {
            IEnumerable<Incidente> incidentes = _repoIncidente.GetAllIncidentes();
            foreach (var incidente in incidentes)
            {
                Console.WriteLine(incidente.IncDescripcion + " " + incidente.IncEstado);
            }
        }
        private static void EliminarIncidente(int idIncidente)
        {
            _repoIncidente.DeleteIncidente(idIncidente);
            Console.WriteLine("incidente Eliminado");
        }
        
    }
}
