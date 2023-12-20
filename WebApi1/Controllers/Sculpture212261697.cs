using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi1.Data;
using WebApi1.Models;


namespace WebApi1.Controllers
{

    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class Sculpture212261697Controller : Controller
    {
        private readonly ManchesterUnitedDbContext _context;

        public Sculpture212261697Controller(ManchesterUnitedDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("ShfaqSculpturent")]
        public async Task<IActionResult> Get()
        {
            var sculpturat= await _context.Sculpture212261697.ToListAsync();

            return Ok(sculpturat);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("ShfaqSculpturenNgaID")]
        public async Task<IActionResult> GetById(int idSculptura)
        {
            var sculptura = await _context.Sculpture212261697.FirstOrDefaultAsync(x => x.SculptureId == idSculptura);

            return Ok(sculptura);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("ShtoSculpturen")]
        public async Task<IActionResult> Post([FromBody] Sculpture212261697 sculptura)
        {
            await _context.Sculpture212261697.AddAsync(sculptura);

            await _context.SaveChangesAsync();

            return CreatedAtAction("get", sculptura.SculptureId, sculptura);
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("PerditesoSculpturen")]
        public async Task<IActionResult> Put(int idScuptura, [FromBody] Sculpture212261697 b)
        {
            var sculptura = await _context.Sculpture212261697.FirstOrDefaultAsync(x => x.SculptureId == idScuptura);

            if (sculptura == null)
            {
                return BadRequest("Sculpturen nuk egziston");
            }

            sculptura.Title = b.Title;

            _context.Sculpture212261697.Update(sculptura);
            await _context.SaveChangesAsync();

            return Ok(sculptura);
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("FshijSculpturen")]
        public async Task<IActionResult> Delete(int idSculptura)
        {
            var sculptura = await _context.Sculpture212261697.FirstOrDefaultAsync(x => x.SculptureId == idSculptura);

            if (sculptura == null)
            {
                return BadRequest("Sculpturen nuk egziston");
            }

            _context.Sculpture212261697.Remove(sculptura);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}