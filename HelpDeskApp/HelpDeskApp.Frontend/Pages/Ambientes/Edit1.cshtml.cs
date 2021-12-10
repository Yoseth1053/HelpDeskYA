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
 public class Edit1Model : PageModel
    {
        private readonly IRepositorioAmbiente _repoAmbiente;
        public Ambiente ambiente {get; set;}
        public Edit1Model(IRepositorioAmbiente repoAmbiente)
        {
            _repoAmbiente= repoAmbiente;
        }
        public IActionResult OnGet(int id)
        {
            ambiente=_repoAmbiente.GetAmbiente(id);
            if (ambiente == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Ambiente ambiente)
            {
               _repoAmbiente.UpdateAmbiente(ambiente);
               return RedirectToPage("Index1"); 
            }
    }
}
