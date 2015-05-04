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
        public virtual Locacion Locacion { get; set; }

        //iafar: falta relacion muchos a muchos con rubros
        //relacion muchos a muchos
        //public virtual ICollection<SubRubro> Subrubros { get; set; }


    }

}