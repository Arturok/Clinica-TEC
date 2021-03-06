using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Health_Tec.Controllers.Presentation;
using Health_Tec.Models;
using Health_Tec.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Health_Tec.Controllers
{
    [Route("/api/clinicas")]
    public class ClinicaController : Controller
    {
        private readonly HealthTecDbContext context;
        private readonly IMapper mapper;

        public ClinicaController(HealthTecDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<ClinicaResource>> GetClinicas()
        {
            var clinicas = await context.Clinicas.Include(m => m.Medicos).Include(p => p.Pacientes).ToListAsync();
            return mapper.Map<List<Clinica>, List<ClinicaResource>>(clinicas);
        }
        [HttpPost]
        public async Task<IActionResult> CreateClinica([FromBody] Clinica clinica)
        {
            if (!ModelState.IsValid) // Si el modelo enviado no es válido
                return BadRequest(ModelState);
            
            if (clinica == null)
                return BadRequest();
            context.Add(clinica);

            return Ok(await context.SaveChangesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClinica(string id)
        {                
            var clinica = await context.Clinicas.FindAsync(id);

            if (clinica == null)
                return NotFound();
            

            return Ok(clinica);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClinica(string id)
        {
            var clinica = await context.Clinicas.FindAsync(id);

            if (clinica == null)
                return NotFound();

            context.Remove(clinica);

            await context.SaveChangesAsync();

            return Ok(id);
        }

    }
}