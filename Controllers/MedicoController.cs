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
    [Route("/api/medicos")]
    public class MedicoController : Controller
    {
        private readonly HealthTecDbContext context;
        private readonly IMapper mapper;

        public MedicoController(HealthTecDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<MedicoResource>> GetMedicos()
        {
            var medicos = await context.Medicos.Include(c => c.Clinicas).Include(p => p.Pacientes).ToListAsync();   
            return mapper.Map<List<Medico>, List<MedicoResource>>(medicos);
        }
        [HttpPost]
        public async Task<IActionResult> CreateMedico([FromBody] Medico medico)
        {
            if (!ModelState.IsValid) // Si el modelo enviado no es válido
                return BadRequest(ModelState);
            
            if (medico == null)
                return BadRequest();
            context.Add(medico);

            return Ok(await context.SaveChangesAsync());
        }
    }
}