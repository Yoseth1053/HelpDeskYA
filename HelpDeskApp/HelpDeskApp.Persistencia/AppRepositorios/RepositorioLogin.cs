using System.Collections.Generic;
using System.Linq;
using HelpDeskApp.Dominio;
using Microsoft.EntityFrameworkCore;


namespace HelpDeskApp.Persistencia
{
    public class RepositorioLogin : IRepositorioLogin
    {
        private readonly AppContext _appContext = new AppContext();

        Login IRepositorioLogin.AddLogin(Login login)
        {
            var loginAdicionado = _appContext.Login.Add(login);
            _appContext.SaveChanges();
            return loginAdicionado.Entity;
        }
        IEnumerable<Login> IRepositorioLogin.GetAllLogin()
        {
            return _appContext.Login;
        }
    }
    
        
    }
