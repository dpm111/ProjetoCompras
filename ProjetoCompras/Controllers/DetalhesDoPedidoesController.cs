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
    public class DetalhesDoPedidoesController : ApiController
    {
        private Context db = new Context();

        // GET: api/DetalhesDoPedidoes
        public IHttpActionResult GetDetalhesDoPedidos()
        {
            var companies = db.DetalhesDoPedidos.Include("CabecalhoOrdemCompra").ToList();
            return Ok(new { results = companies });
        }

        // GET: api/DetalhesDoPedidoes/5
        [ResponseType(typeof(DetalhesDoPedido))]
        public IHttpActionResult GetDetalhesDoPedido(int id)
        {
            DetalhesDoPedido detalhesDoPedido = db.DetalhesDoPedidos.Find(id);
            if (detalhesDoPedido == null)
            {
                return NotFound();
            }

            return Ok(detalhesDoPedido);
        }

        // PUT: api/DetalhesDoPedidoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDetalhesDoPedido(int id, DetalhesDoPedido detalhesDoPedido)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != detalhesDoPedido.DetalhesPedidoID)
            {
                return BadRequest();
            }

            db.Entry(detalhesDoPedido).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalhesDoPedidoExists(id))
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

        // POST: api/DetalhesDoPedidoes
        [ResponseType(typeof(DetalhesDoPedido))]
        public IHttpActionResult PostDetalhesDoPedido(DetalhesDoPedido detalhesDoPedido)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DetalhesDoPedidos.Add(detalhesDoPedido);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = detalhesDoPedido.DetalhesPedidoID }, detalhesDoPedido);
        }

        // DELETE: api/DetalhesDoPedidoes/5
        [ResponseType(typeof(DetalhesDoPedido))]
        public IHttpActionResult DeleteDetalhesDoPedido(int id)
        {
            DetalhesDoPedido detalhesDoPedido = db.DetalhesDoPedidos.Find(id);
            if (detalhesDoPedido == null)
            {
                return NotFound();
            }

            db.DetalhesDoPedidos.Remove(detalhesDoPedido);
            db.SaveChanges();

            return Ok(detalhesDoPedido);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DetalhesDoPedidoExists(int id)
        {
            return db.DetalhesDoPedidos.Count(e => e.DetalhesPedidoID == id) > 0;
        }
    }
}