namespace HelpDeskApp.Dominio
{
    public class Empleado
    {
        public int Id {get ; set;}
        public string EmpDocumento {get ; set;}
        public string EmpNombres {get ; set;}
        public string EmpApellidos {get ; set;}
        public string EmpCelular {get ; set;}
        public string EmpCorreo {get ; set;}
        public TipoEmpleado TipoEmpleado {get ; set;}
    }
}