using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data.Entity;
using WebApi1.Data;
using WebApi1.Models;

namespace WebApi1.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    [Route("/api/[controller]")]
    public class TeDhenatBiznesitController : Controller
    {
        private readonly ManchesterUnitedDbContext _context;

        public TeDhenatBiznesitController(ManchesterUnitedDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("ShfaqTeDhenat")]
        public IActionResult Get()
        {
            var teDhenat = _context.TeDhenatBiznesit.First();

            return Ok(teDhenat);
        }

        [Authorize(Roles = "Admin, Menaxher")]
        [HttpPut]
        [Route("perditesoTeDhenat")]
        public IActionResult Put([FromBody] TeDhenatBiznesit k)
        {
            var teDhenat = _context.TeDhenatBiznesit.FirstOrDefault(x => x.IdteDhenatBiznesit == 1);
            if (teDhenat == null)
            {
                return BadRequest("Kategoria nuk egziston");
            }

            teDhenat.NrKontaktit = k.NrKontaktit;
            teDhenat.Nf = k.Nf;
            teDhenat.Nui = k.Nui;
            teDhenat.Email = k.Email;
            teDhenat.EmriIbiznesit = k.EmriIbiznesit;
            teDhenat.ShkurtesaEmritBiznesit = k.ShkurtesaEmritBiznesit;
            teDhenat.Nrtvsh = k.Nrtvsh;
            teDhenat.Adresa = k.Adresa;
            teDhenat.Logo = k.Logo;

            _context.SaveChanges();

            return Ok(teDhenat);
        }
    }
}