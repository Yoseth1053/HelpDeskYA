using System.Collections.Generic;

using HelpDeskApp.Dominio;


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
         void IRepositorioAmbiente.DeleteAmbiente(int idAmbiente)
        {
            var ambienteEncontrado = _appContext.Ambientes.Find(idAmbiente);
            if (ambienteEncontrado == null)
                return;
            _appContext.Ambientes.Remove(ambienteEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Ambiente> IRepositorioAmbiente.GetAllAmbientes()
        {
            return _appContext.Ambientes;
        }
        Ambiente IRepositorioAmbiente.GetAmbiente(int idAmbiente)
        {
            return _appContext.Ambientes.Find(idAmbiente);
        }
        Ambiente IRepositorioAmbiente.UpdateAmbiente(Ambiente ambiente)
        {
            var ambienteEncontrado = _appContext.Ambientes.Find(ambiente.Id);
            if (ambienteEncontrado != null)
            {
                
                ambienteEncontrado.AmbNombre = ambiente.AmbNombre;
                ambienteEncontrado.AmbUbicacion = ambiente.AmbUbicacion;
                _appContext.SaveChanges();
            }
            return ambienteEncontrado;
        }
            
    }
}