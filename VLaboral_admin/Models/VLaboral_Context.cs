using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace VLaboral_admin.Models
{
    public class VLaboral_Context : DbContext
    {
        public VLaboral_Context() : base("VLaboral_Context")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            //fpaz: configuracion para el llenado inicial de la base de datos            
            Database.SetInitializer<VLaboral_Context>(new VLaboralDB_Initializer());
            //Database.SetInitializer<VLaboral_Context>(new DropCreateDatabaseIfModelChanges<VLaboral_Context>());
  
        }

        #region Definicion de Tablas DbSet

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Curriculum> Curriculums { get; set; }
        public DbSet<Empleador> Empleadores { get; set; }
        public DbSet<Rubro> Rubros { get; set; }
        public DbSet<SubRubro> SubRubros { get; set; }
        public DbSet<PaisRegion> PaisRegiones { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<UbicacionActual> UbicacionActuales { get; set; }
        public DbSet<UbicacionOrigen> UbicacionOrigenes { get; set; }



        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //fpaz: para relacion 1 a 1 entre cliente y cuenta corriente defino que ClienteId va a ser ka ForeingKey de la relacion 1 a 1 y asi poder usar el properti cliente para navegacion
            modelBuilder.Entity<Empleado>()
                        .HasRequired(a => a.Curriculum)
                        .WithMany()
                        .HasForeignKey(u => u.CurriculumId);

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<VLaboral_admin.Models.Curriculum> Curricula { get; set; }     



    }

  


#region Definicion de semillas  

    public class VLaboralDB_Initializer:DropCreateDatabaseIfModelChanges<VLaboral_Context>
    {
        protected override void Seed(VLaboral_Context context)
        {
            // fpaz: semilla para llenado inicial de base de datos
            //#region Semilla de tipo de forma de pago
            //var tiposFormasPagos = new List<TipoFormaPago>
            //    {
            //        new TipoFormaPago {Descripcion="Pago en Efectivo"},
            //        new TipoFormaPago {Descripcion="Pago con Cuenta Corriente"},
            //        new TipoFormaPago {Descripcion="Pago con Cheque"}                    
            //    };
            //foreach (var item in tiposFormasPagos)
            //{
            //    context.TiposFormasPago.Add(item);
            //}
            //#endregion

            //#region Semilla de tipo de estado de cuenta corriente
            //var tiposEstadoCC = new List<TipoEstado>
            //    {
            //        new TipoEstado {Descripcion="Activado"},
            //        new TipoEstado {Descripcion="Desactivadoctivado"}         
            //    };
            //foreach (var item in tiposEstadoCC)
            //{
            //    context.TiposEstado.Add(item);
            //}
            //#endregion

            //#region Semilla de tipo de movimientos de cajas
            //var tiposMovCaja = new List<TipoMovCaja>
            //    {
            //        new TipoMovCaja {Nombre="Ajuste Negativo", Egreso=true},
            //        new TipoMovCaja {Nombre="Ajuste Positivo", Egreso=false},
            //        new TipoMovCaja {Nombre="Extraccion", Egreso=true},
            //        new TipoMovCaja {Nombre="Deposito de Efectivo", Egreso=false},
            //        new TipoMovCaja {Nombre="Venta en Efectivo", Egreso=false},
            //        new TipoMovCaja {Nombre="Pago en Efectivo", Egreso=false},
            //        new TipoMovCaja {Nombre="Deposito de Efectivo en Cuenta Corriente", Egreso=false}
                    
            //    };
            //foreach (var item in tiposMovCaja)
            //{
            //    context.TipoMovCajas.Add(item);
            //}
            //#endregion

            //#region Semilla de tipo de movimientos de Cuentas Corrientes
            //var tiposMovCC = new List<TipoMovCC>
            //    {
            //        new TipoMovCC {Descripcion="Pago por Compra", Egreso=true},
            //        new TipoMovCC {Descripcion="Deposito de Efectivo", Egreso=false}
            //    };

            //foreach (var item in tiposMovCC)
            //{
            //    context.TipoMovCCs.Add(item);
            //}
            //#endregion

            //#region Semilla de tipo de trabajos y trabajos
            //var tiposTrabajos = new List<TipoTrabajo>
            //    {
            //        new TipoTrabajo {Nombre="Varios", // trabajo temporal generado para pruebas
            //            Trabajos = new List<Trabajo>(){
            //                new Trabajo(){
            //                    Nombre = "Trabajo1",
            //                    PrecioUnitario=12,
            //                    UMedida="cm"
            //                }
            //            }
            //        },
            //        new TipoTrabajo {Nombre="Diseños"},
            //        new TipoTrabajo {Nombre="Anillados"},
            //        new TipoTrabajo {Nombre="Ploteo"},
            //        new TipoTrabajo {Nombre="Fotocopias e Impresiones Color"},
            //        new TipoTrabajo {Nombre="Fotocopias e Impresiones B/N"},
            //        new TipoTrabajo {Nombre="Plastificados"}
            //    };
            //foreach (var item in tiposTrabajos)
            //{
            //    context.TipoTrabajos.Add(item);
            //}
            //#endregion

            //#region Semilla (TEMPORAL) de Cajas
            //var caja = new Caja(){
            //    FechaApertura = DateTime.Now, 
            //    FechaCierre=DateTime.Now,
            //    MontoApertura = 0,
            //    MontoCierre = 0,
            //    Abierto = true
            //};

            //context.Cajas.Add(caja);            
            //#endregion

            



            //    base.Seed(context);
        }
    }

}

#endregion