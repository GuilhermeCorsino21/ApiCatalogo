using CatalogoApi.Context;
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
            


    }
}
