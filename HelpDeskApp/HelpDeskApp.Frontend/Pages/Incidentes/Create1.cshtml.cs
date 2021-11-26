using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelpDeskApp.Dominio;
using HelpDeskApp.Persistencia;

namespace HelpDeskApp.frontend.Pages.Incidentes
{
    public class Create1Model : PageModel
{

        private readonly IRepositorioIncidente _repoIncidente;
        public Incidente incidente {get; set;}
        public Create1Model(IRepositorioIncidente repoIncidente)
        {
            _repoIncidente = repoIncidente;
        }
        public void OnGet()
        {
            incidente = new Incidente();
        }

        public IActionResult OnPost(Incidente incidente)
        {
            if (ModelState.IsValid)
            {
                _repoIncidente.AddIncidente(incidente);
                return RedirectToPage("Index1");
            } else
            {
                return Page();
            }
        }
    }
}

