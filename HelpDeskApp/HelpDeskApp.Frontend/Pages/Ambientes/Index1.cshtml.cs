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
    public class Index1Model : PageModel
    {
        private readonly IRepositorioAmbiente _repoAmbiente;
        public IEnumerable<Ambiente> ambientes {get; set;}
        public Index1Model(IRepositorioAmbiente repoAmbiente)
        {
            _repoAmbiente = repoAmbiente;
        }
        public void OnGet()
        {
            ambientes = _repoAmbiente.GetAllAmbientes();
        }
    }
}
