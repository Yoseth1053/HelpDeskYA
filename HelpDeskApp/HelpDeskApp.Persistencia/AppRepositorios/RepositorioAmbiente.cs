using System.Collections.Generic;
using System.Linq;
using HelpDeskApp.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskApp.Persistencia
{
    public class RepositorioAmbiente : IRepositorioAmbiente
    {
        private readonly AppContext _appContext = new AppContext();

        Ambiente IRepositorioAmbiente.AddAmbiente(Ambiente ambiente)
        {
            var ambienteAdicionado = _appContext.Ambientes.Add(ambiente);
            _appContext.SaveChanges();
            return ambienteAdicionado.Entity;
        }
        IEnumerable<Ambiente> IRepositorioAmbiente.GetAllAmbientes()
        {
            return _appContext.Ambientes;
        }
            
    }
}