using Microsoft.EntityFrameworkCore;
using HelpDeskApp.Dominio;

namespace HelpDeskApp.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Empleados> Empleados {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Initial Catalog=ProyectoFinalADSI2207208; Data Source=LAPTOP-14PD7JPN; Integrated Security=true");
            }
        }
    }
}