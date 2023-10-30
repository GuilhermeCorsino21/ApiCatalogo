using CatalogoApi.Context;
using CatalogoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatalogoApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly CatalogoApiDbContext _context;

        public ProdutosController(CatalogoApiDbContext context)
        {
            _context = context;
        }

        [HttpGet] // primeiro método action
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _context.Produto.ToList();
            if (produtos is null)
            {
                return NotFound("O produto não existe");
            }
            return produtos;
        }

        [HttpGet("{id:int}", Name = "ObterProduto")] // get by id

        public ActionResult<Produto> Get(int id) 
        {
            var produto = _context.Produto.FirstOrDefault( p => p.ProdutoId == id);
            if (produto is null) 
            {
                return NotFound("Esse produto não existe");
            }

            return produto;    
        }

        [HttpPost]
        
        public ActionResult Post(Produto produto)
        {
                        
            if (produto is null)
                return BadRequest();

            _context.Produto.Add(produto);
            _context.SaveChanges();

            return new CreatedAtRouteResult( "ObterProduto", new { id = produto.ProdutoId }, produto); 
        }


        [HttpPut("{id:int}")]

        public ActionResult Put(int id, Produto produto) 
        {
            if(id != produto.ProdutoId)
            {
                return BadRequest();
            }

            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(produto);
        
        }
        
        [HttpDelete("{id:int}")]

        public ActionResult Delete(int id) 
        {
            var produto = _context.Produto.FirstOrDefault( p => p.ProdutoId ==id);

            if (produto is null) 
            {
                return NotFound("Produto não localizado");
            }

            _context.Produto.Remove(produto);
            _context.SaveChanges();

            return Ok(produto);               

        }
          

            


    }
}
