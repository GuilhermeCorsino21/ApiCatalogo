using CatalogoApi.Context;
using CatalogoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("{id}")]

        public ActionResult<Produto> Get(int id) 
        {
            var produto = _context.Produto.FirstOrDefault( p => p.ProdutoId == id);
            if (produto is null) 
            {
                return NotFound("Esse produto não existe");
            }

            return produto;    
        }
            


    }
}
