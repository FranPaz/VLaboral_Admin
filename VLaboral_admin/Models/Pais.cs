using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLaboral_admin.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Idioma { get; set; }
        public string ZHoraria { get; set; }

        //Relacion 1 a muchos
        public int LocalidadId { get; set; }
        public virtual Localidad Localidad { get; set; }
    }

    public class Localidad
    {
        
    }
}