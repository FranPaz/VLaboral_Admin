using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLaboral_admin.Models
{
    public class Rubro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //relacion 1 a muchos(muchos)
        public virtual ICollection<SubRubro> SubRubros { get; set; }

    }

    public class SubRubro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //Relacion 1 a muchos(1)
        public int RubroId { get; set; }
        public virtual Rubro Rubro { get; set; }


        //iafar: Falta el muchos a muchos con empleado y empleador

        
    }
}