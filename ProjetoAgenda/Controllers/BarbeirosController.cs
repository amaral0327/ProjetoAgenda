using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAgenda.Data;
using ProjetoAgenda.Models;

namespace ProjetoAgenda.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class BarbeirosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BarbeirosController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetBarbeiros()
        {
            var barbeiros = await _context.Barbeiros.ToListAsync();
            return Ok(barbeiros);
        }
    }
}
