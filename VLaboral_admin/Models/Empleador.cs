using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VLaboral_admin.Models
{
    public class Empleador
    {
        public int Id { get; set; }
        public string Cuit { get; set; }
        public string Rsocial { get; set; }
        public string Dir { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Descripcion { get; set; }

        //relacion 1 a muchos(1)
        public int LocalidadId { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }

        //relacion muchos a muchos
        public virtual ICollection<SubRubro> Subrubros { get; set; }


    }

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

        //Relacion muchos a muchos
        public virtual ICollection<Empleador> Empleadores { get; set; }
    }

}