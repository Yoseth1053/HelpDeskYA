using System.Collections.Generic;
using HelpDeskApp.Dominio;

namespace HelpDeskApp.Persistencia
{
    public interface IRepositorioAmbiente
    {
        IEnumerable<Ambiente> GetAllAmbientes();
        Ambiente AddAmbiente(Ambiente ambiente);
    }
}