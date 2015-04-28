using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLaboral_admin.Models
{
    public class PaisRegion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Idioma { get; set; }
        public string ZHoraria { get; set; }

        //Relacion 1 a muchos (muchos)
        public virtual ICollection<Ubicacion> Localidades { get; set; }
    }

    public class Ubicacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
        //Relacion 1 a muchos(uno)
        public int PaisId { get; set; }
        public virtual Ubicacion Localidad { get; set; }

        //Relacion 1 a muchos(muchos)
        public virtual ICollection<Empleado> Empleados { get; set; }
        //Relacion 1 a muchos(muchos)
        public virtual ICollection<Empleador> Empleadores { get; set; }

    }
}