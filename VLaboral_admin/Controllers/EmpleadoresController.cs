using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using VLaboral_admin.Models;

namespace VLaboral_admin.Controllers
{
    public class EmpleadoresController : ApiController
    {
        private VLaboral_Context db = new VLaboral_Context();

        // GET: api/Empleadores
        public IQueryable<Empleador> GetEmpleadores()
        {
            return db.Empleadores;
        }

        // GET: api/Empleadores/5
        [ResponseType(typeof(Empleador))]
        public IHttpActionResult GetEmpleador(int id)
        {
            Empleador empleador = db.Empleadores.Find(id);
            if (empleador == null)
            {
                return NotFound();
            }

            return Ok(empleador);
        }

        // PUT: api/Empleadores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmpleador(int id, Empleador empleador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != empleador.Id)
            {
                return BadRequest();
            }

            db.Entry(empleador).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Empleadores
        [ResponseType(typeof(Empleador))]
        public IHttpActionResult PostEmpleador(Empleador empleador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Empleadores.Add(empleador);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = empleador.Id }, empleador);
        }

        // DELETE: api/Empleadores/5
        [ResponseType(typeof(Empleador))]
        public IHttpActionResult DeleteEmpleador(int id)
        {
            Empleador empleador = db.Empleadores.Find(id);
            if (empleador == null)
            {
                return NotFound();
            }

            db.Empleadores.Remove(empleador);
            db.SaveChanges();

            return Ok(empleador);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmpleadorExists(int id)
        {
            return db.Empleadores.Count(e => e.Id == id) > 0;
        }
    }
}