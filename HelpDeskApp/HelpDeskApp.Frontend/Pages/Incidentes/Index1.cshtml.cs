using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelpDeskApp.Dominio;
using HelpDeskApp.Persistencia;

namespace HelpDeskApp.Frontend.Pages.Incidentes
{
    public class Index1Model : PageModel
    {
        private readonly IRepositorioIncidente _repoIncidente;
        public IEnumerable<Incidente> incidentes {get; set;}
        public Index1Model(IRepositorioIncidente repoIncidente)
        {
            _repoIncidente = repoIncidente;
        }
        public void OnGet()
        {
            incidentes = _repoIncidente.GetAllIncidentes();
        }
    }
}
