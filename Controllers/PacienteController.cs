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
    [Route("/api/pacientes")]
    public class PacienteController : Controller
    {
        private readonly HealthTecDbContext context;
        private readonly IMapper mapper;

        public PacienteController(HealthTecDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<PacienteResource>> GetPacientes()
        {
            var pacientes = await context.Pacientes.Include(t => t.Telefonos).Include(c => c.Clinicas).Include(m => m.Medicos).Include(e => e.Estado).ToListAsync();
            return mapper.Map<List<Paciente>, List<PacienteResource>>(pacientes);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePaciente([FromBody] Paciente paciente)
        {
            if (!ModelState.IsValid) // Si el modelo enviado no es válido
                return BadRequest(ModelState);
            
            if (paciente == null)
                return BadRequest();
            context.Add(paciente);

            return Ok(await context.SaveChangesAsync());
        }
    }
}