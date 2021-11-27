using System.Collections.Generic;
using HelpDeskApp.Dominio;

namespace HelpDeskApp.Persistencia
{
    public interface IRepositorioAmbiente
    {
        IEnumerable<Ambiente> GetAllAmbientes();
        Ambiente AddAmbiente(Ambiente ambiente);
        Ambiente UpdateAmbiente(Ambiente ambiente);
        void DeleteAmbiente(int idAmbiente);    
        Ambiente GetAmbiente(int idAmbiente);
    }
}