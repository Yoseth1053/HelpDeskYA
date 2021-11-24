using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelpDeskApp.Dominio;
using HelpDeskApp.Persistencia;

namespace HelpDeskApp.Frontend.Pages.Empleados
{
    public class Create1Model : PageModel
    {

        private readonly IRepositorioEmpleado _repoEmpleado;
        public Empleado empleado {get; set;}
        public Create1Model(IRepositorioEmpleado repoEmpleado)
        {
            _repoEmpleado = repoEmpleado;
        }
        public void OnGet()
        {
            empleado = new Empleado();
        }

        public IActionResult OnPost(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _repoEmpleado.AddEmpleado(empleado);
                return RedirectToPage("Index1");
            } else
            {
                return Page();
            }
        }
    }
}
