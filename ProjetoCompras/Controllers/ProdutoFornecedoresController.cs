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
    public class ProdutoFornecedoresController : ApiController
    {
        private Context db = new Context();

        // GET: api/ProdutoFornecedores
        public IHttpActionResult GetProdutoFornecedores()
        {
            var companies = db.ProdutoFornecedores.ToList();
            return Ok(new { results = companies });
        }

        // GET: api/ProdutoFornecedores/5
        [ResponseType(typeof(ProdutoFornecedor))]
        public IHttpActionResult GetProdutoFornecedor(int id)
        {
            ProdutoFornecedor produtoFornecedor = db.ProdutoFornecedores.Find(id);
            if (produtoFornecedor == null)
            {
                return NotFound();
            }

            return Ok(produtoFornecedor);
        }

        // PUT: api/ProdutoFornecedores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProdutoFornecedor(int id, ProdutoFornecedor produtoFornecedor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != produtoFornecedor.ProdutoID)
            {
                return BadRequest();
            }

            db.Entry(produtoFornecedor).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoFornecedorExists(id))
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

        // POST: api/ProdutoFornecedores
        [ResponseType(typeof(ProdutoFornecedor))]
        public IHttpActionResult PostProdutoFornecedor(ProdutoFornecedor produtoFornecedor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProdutoFornecedores.Add(produtoFornecedor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = produtoFornecedor.ProdutoID }, produtoFornecedor);
        }

        // DELETE: api/ProdutoFornecedores/5
        [ResponseType(typeof(ProdutoFornecedor))]
        public IHttpActionResult DeleteProdutoFornecedor(int id)
        {
            ProdutoFornecedor produtoFornecedor = db.ProdutoFornecedores.Find(id);
            if (produtoFornecedor == null)
            {
                return NotFound();
            }

            db.ProdutoFornecedores.Remove(produtoFornecedor);
            db.SaveChanges();

            return Ok(produtoFornecedor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProdutoFornecedorExists(int id)
        {
            return db.ProdutoFornecedores.Count(e => e.ProdutoID == id) > 0;
        }
    }
}