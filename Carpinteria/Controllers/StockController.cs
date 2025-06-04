using Carpinteria.Data;
using Carpinteria.Modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Carpinteria.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {


        private readonly CarpinteriaContext _context;

        public StockController(CarpinteriaContext context)
        {
            _context = context;
        }
      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stock>>> GetStock()
        {
            return await _context.Stocks.ToListAsync();
        }

    }
}
