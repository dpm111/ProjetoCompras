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
    public class FornecedoresController : ApiController
    {
        private Context db = new Context();

        // GET: api/Fornecedores
        public IHttpActionResult GetFornecedores()
        {
            var companies = db.Fornecedores.Include("CabecalhoOrdemCompra").ToList();
            return Ok(new { results = companies });
        }

        // GET: api/Fornecedores/5
        [ResponseType(typeof(Fornecedor))]
        public IHttpActionResult GetFornecedor(int id)
        {
            Fornecedor fornecedor = db.Fornecedores.Find(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return Ok(fornecedor);
        }

        // PUT: api/Fornecedores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFornecedor(int id, Fornecedor fornecedor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fornecedor.UnidadeDeNegocioID)
            {
                return BadRequest();
            }

            db.Entry(fornecedor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FornecedorExists(id))
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

        // POST: api/Fornecedores
        [ResponseType(typeof(Fornecedor))]
        public IHttpActionResult PostFornecedor(Fornecedor fornecedor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Fornecedores.Add(fornecedor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = fornecedor.UnidadeDeNegocioID }, fornecedor);
        }

        // DELETE: api/Fornecedores/5
        [ResponseType(typeof(Fornecedor))]
        public IHttpActionResult DeleteFornecedor(int id)
        {
            Fornecedor fornecedor = db.Fornecedores.Find(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            db.Fornecedores.Remove(fornecedor);
            db.SaveChanges();

            return Ok(fornecedor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FornecedorExists(int id)
        {
            return db.Fornecedores.Count(e => e.UnidadeDeNegocioID == id) > 0;
        }
    }
}