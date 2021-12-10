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
public class Details1Model : PageModel
    {
        private readonly IRepositorioIncidente _repoIncidente;
        public Incidente incidente {get; set;}
        public Details1Model(IRepositorioIncidente repoIncidente)
        {
            _repoIncidente= repoIncidente;
        }
        public IActionResult OnGet(int id)
        {
            incidente = _repoIncidente.GetIncidente(id);
            if (incidente == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }
        }
    }
}

