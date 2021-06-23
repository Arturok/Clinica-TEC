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
    }
}