using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelpDeskApp.Dominio;
using HelpDeskApp.Persistencia;

namespace HelpDeskApp.Frontend.Pages
{
    public class Index1Model : PageModel
    {
        private readonly IRepositorioEmpleado _repoEmpleado;
        public IEnumerable<Empleado> empleados {get; set;}
        public Index1Model(IRepositorioEmpleado repoEmpleado)
        {
            _repoEmpleado = repoEmpleado;
        }
        public void OnGet()
        {
            empleados = _repoEmpleado.GetAllEmpleados();
        }
    }
}
