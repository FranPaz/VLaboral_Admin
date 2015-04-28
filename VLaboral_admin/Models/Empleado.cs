using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLaboral_admin.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public String NombreApellido { get; set; }
        public String CiudadDeOrigen { get; set; }
        public String Pais { get; set; }
        public String Email { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }

        public virtual Curriculum Curriculum { get; set; }
        
    }

    public class Curriculum
    {   
        public int EmpleadoId { get; set; }

        public int Id { get; set; }
        public String Habilidades { get; set; }
        public String Descripcion { get; set; }

        public virtual Empleado Empleado { get; set; }
    }

}