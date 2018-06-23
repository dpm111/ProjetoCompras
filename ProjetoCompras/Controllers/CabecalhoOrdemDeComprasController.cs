using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ProjetoCompras.Models;

namespace ProjetoCompras.Controllers
{
    public class CabecalhoOrdemDeComprasController : ApiController
    {
        private Context db = new Context();

        // GET: api/CabecalhoOrdemDeCompras
        public IHttpActionResult GetCabecalhoOrdemDeCompras()
        {
            var companies = db.CabecalhoOrdemDeCompras.Include("Fornecedor").Include("DetalhesPedidos").ToList();
            return Ok(new { cabecalhoOrdemDeCompras = companies });
        }

        // GET: api/CabecalhoOrdemDeCompras/5
        [ResponseType(typeof(CabecalhoOrdemDeCompras))]
        public IHttpActionResult GetCabecalhoOrdemDeCompras(int id)
        {
            CabecalhoOrdemDeCompras cabecalhoOrdemDeCompras = db.CabecalhoOrdemDeCompras.Find(id);
            if (cabecalhoOrdemDeCompras == null)
            {
                return NotFound();
            }

            return Ok(cabecalhoOrdemDeCompras);
        }

        // PUT: api/CabecalhoOrdemDeCompras/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCabecalhoOrdemDeCompras(int id, CabecalhoOrdemDeCompras cabecalhoOrdemDeCompras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cabecalhoOrdemDeCompras.PedidoDaCompraID)
            {
                return BadRequest();
            }

            cabecalhoOrdemDeCompras.DataModificacao = DateTime.Now;
            db.Entry(cabecalhoOrdemDeCompras).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CabecalhoOrdemDeComprasExists(id))
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

        // POST: api/CabecalhoOrdemDeCompras
        [ResponseType(typeof(CabecalhoOrdemDeCompras))]
        public IHttpActionResult PostCabecalhoOrdemDeCompras(CabecalhoOrdemDeCompras cabecalhoOrdemDeCompras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            cabecalhoOrdemDeCompras.DataModificacao = DateTime.Now;
            db.CabecalhoOrdemDeCompras.Add(cabecalhoOrdemDeCompras);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cabecalhoOrdemDeCompras.PedidoDaCompraID }, cabecalhoOrdemDeCompras);
        }

        // DELETE: api/CabecalhoOrdemDeCompras/5
        [ResponseType(typeof(CabecalhoOrdemDeCompras))]
        public IHttpActionResult DeleteCabecalhoOrdemDeCompras(int id)
        {
            CabecalhoOrdemDeCompras cabecalhoOrdemDeCompras = db.CabecalhoOrdemDeCompras.Find(id);
            if (cabecalhoOrdemDeCompras == null)
            {
                return NotFound();
            }

            db.CabecalhoOrdemDeCompras.Remove(cabecalhoOrdemDeCompras);
            db.SaveChanges();

            return Ok(cabecalhoOrdemDeCompras);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CabecalhoOrdemDeComprasExists(int id)
        {
            return db.CabecalhoOrdemDeCompras.Count(e => e.PedidoDaCompraID == id) > 0;
        }
    }
}