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
    [ApiController]
    [Route("[controller]")]
    public class EstadoController : Controller
    {
        private readonly HealthTecDbContext context;
        private readonly IMapper mapper;

        public EstadoController(HealthTecDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }        
        [HttpGet("/api/estados")]
        public async Task<IEnumerable<EstadoResource>> GetEstadosAsync()
        {
            var estados = await context.Estados.ToListAsync();
            return mapper.Map<List<Estado>, List<EstadoResource>>(estados);
        }
    }
}