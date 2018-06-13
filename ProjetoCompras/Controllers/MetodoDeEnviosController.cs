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
using ProjetoCompras.Models;

namespace ProjetoCompras.Controllers
{
    public class MetodoDeEnviosController : ApiController
    {
        private Context db = new Context();

        // GET: api/MetodoDeEnvios
        public IHttpActionResult GetMetodoDeEnvios()
        {
            var companies = db.MetodoDeEnvios.Include("CabecalhoOrdemCompra").ToList();
            return Ok(new { results = companies });
        }

        // GET: api/MetodoDeEnvios/5
        [ResponseType(typeof(MetodoDeEnvio))]
        public IHttpActionResult GetMetodoDeEnvio(int id)
        {
            MetodoDeEnvio metodoDeEnvio = db.MetodoDeEnvios.Find(id);
            if (metodoDeEnvio == null)
            {
                return NotFound();
            }

            return Ok(metodoDeEnvio);
        }

        // PUT: api/MetodoDeEnvios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMetodoDeEnvio(int id, MetodoDeEnvio metodoDeEnvio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != metodoDeEnvio.MetodoEnvioID)
            {
                return BadRequest();
            }

            db.Entry(metodoDeEnvio).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MetodoDeEnvioExists(id))
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

        // POST: api/MetodoDeEnvios
        [ResponseType(typeof(MetodoDeEnvio))]
        public IHttpActionResult PostMetodoDeEnvio(MetodoDeEnvio metodoDeEnvio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MetodoDeEnvios.Add(metodoDeEnvio);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = metodoDeEnvio.MetodoEnvioID }, metodoDeEnvio);
        }

        // DELETE: api/MetodoDeEnvios/5
        [ResponseType(typeof(MetodoDeEnvio))]
        public IHttpActionResult DeleteMetodoDeEnvio(int id)
        {
            MetodoDeEnvio metodoDeEnvio = db.MetodoDeEnvios.Find(id);
            if (metodoDeEnvio == null)
            {
                return NotFound();
            }

            db.MetodoDeEnvios.Remove(metodoDeEnvio);
            db.SaveChanges();

            return Ok(metodoDeEnvio);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MetodoDeEnvioExists(int id)
        {
            return db.MetodoDeEnvios.Count(e => e.MetodoEnvioID == id) > 0;
        }
    }
}