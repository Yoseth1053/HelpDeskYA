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
    public class Create1Model : PageModel
   {

        private readonly IRepositorioAmbiente _repoAmbiente;
        public Ambiente ambiente {get; set;}
        public Create1Model(IRepositorioAmbiente repoAmbiente)
        {
            _repoAmbiente = repoAmbiente;
        }
        public void OnGet()
        {
            ambiente = new Ambiente();
        }

        public IActionResult OnPost(Ambiente ambiente)
        {
            if (ModelState.IsValid)
            {
                _repoAmbiente.AddAmbiente(ambiente);
                return RedirectToPage("Index1");
            } else
            {
                return Page();
            }
        }
    }
}
