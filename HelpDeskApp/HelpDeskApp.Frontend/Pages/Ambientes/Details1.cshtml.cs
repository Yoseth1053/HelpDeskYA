using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelpDeskApp.Dominio;
using HelpDeskApp.Persistencia;

namespace HelpDeskApp.frontend.Pages.Ambientes
{
public class Details1Model : PageModel
    {
        private readonly IRepositorioAmbiente _repoAmbiente;
        public Ambiente ambiente {get; set;}
        public Details1Model(IRepositorioAmbiente repoAmbiente)
        {
            _repoAmbiente= repoAmbiente;
        }
        public IActionResult OnGet(int id)
        {
            ambiente = _repoAmbiente.GetAmbiente(id);
            if (ambiente == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }
        }
    }
}
