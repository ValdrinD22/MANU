using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi1.Models;
using WebApi1.Data;

namespace WebApi1.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class Sculptor212261697Controller : Controller
    {
        private readonly ManchesterUnitedDbContext _context;

        public Sculptor212261697Controller(ManchesterUnitedDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("ShfaqSculptorin")]
        public async Task<IActionResult> Get()
        {
            var sculptort = await _context.Sculptor212261697.Include(x => x.Sculpture2122).ToListAsync();

            return Ok(sculptort);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("ShfaqSculptorinNgaID")]
        public async Task<IActionResult> GetById(int idsculptori)
        {
            var sculptori = await _context.Sculptor212261697.Include(x => x.SculptorId).FirstOrDefaultAsync(x => x.SculptorId == idsculptori);

            return Ok(sculptori);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("ShtoSculptorin")]
        public async Task<IActionResult> Post([FromBody] Sculptor212261697 sculptori)
        {
            await _context.Sculptor212261697.AddAsync(sculptori);

            await _context.SaveChangesAsync();

            return CreatedAtAction("get", sculptori.SculptorId, sculptori);
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("PerditesoSculptorin")]
        public async Task<IActionResult> Put(int idsculptori, [FromBody] Sculptor212261697 b)
        {
            var sculptori = await _context.Sculptor212261697.FirstOrDefaultAsync(x => x.SculptorId == idsculptori);

            if (sculptori == null)
            {
                return BadRequest("Personi nuk egziston");
            }
            sculptori.Emri = b.Emri;
            sculptori.DataLindjes = b.DataLindjes;
            sculptori.Sculpture2122 = b.Sculpture2122;

            _context.Sculptor212261697.Update(sculptori);
            await _context.SaveChangesAsync();

            return Ok(sculptori);
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("FshijSculptorin")]
        public async Task<IActionResult> Delete(int idSculptori)
        {
            var sculptori = await _context.Sculptor212261697.FirstOrDefaultAsync(x => x.SculptorId == idSculptori);

            if (sculptori == null)
            {
                return BadRequest("Personi nuk egziston");
            }

            _context.Sculptor212261697.Remove(sculptori);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}