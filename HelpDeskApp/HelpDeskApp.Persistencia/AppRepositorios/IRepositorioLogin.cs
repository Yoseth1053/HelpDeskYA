using System.Collections.Generic;
using HelpDeskApp.Dominio;

namespace HelpDeskApp.Persistencia
{
    public interface IRepositorioLogin
    {
        IEnumerable<Login> GetAllLogin();
        Login AddLogin(Login login);
    }
}