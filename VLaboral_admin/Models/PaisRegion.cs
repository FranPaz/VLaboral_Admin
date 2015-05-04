using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VLaboral_admin.Models
{
    public class PaisRegion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Idioma { get; set; }
        public string ZHoraria { get; set; }

        //Relacion 1 a muchos (muchos)
        public virtual ICollection<Ubicacion> Ubicaciones { get; set; }
    }

    public abstract class Ubicacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
        //Relacion 1 a muchos(uno)
        public int PaisRegionId { get; set; }
        public virtual PaisRegion PaisRegion { get; set; }

    }

    #region Herencia de clase abstracta
    //iafar: Necesaria para poder referenciar la ubicacion de origen y la actual del empleado

    [Table("UbicacionOrigen")]
    public class UbicacionOrigen : Ubicacion
    {
        //Relacion 1 a muchos(muchos)
        public virtual ICollection<Empleado> Empleados { get; set; } 
    }


    [Table("UbicacionActual")]
    public class UbicacionActual : Ubicacion 
    {
        //Relacion 1 a muchos(muchos)
        public virtual ICollection<Empleado> Empleados { get; set; }
    }

    //Para la ubicacion de la empresa
    [Table("Locacion")]
    public class Locacion : Ubicacion
    {
        //Relacion 1 a muchos(muchos)
        public virtual ICollection<Empleador> Empleadores { get; set; }
    }

    #endregion


}