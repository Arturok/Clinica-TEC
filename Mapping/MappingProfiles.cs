using AutoMapper;
using Health_Tec.Controllers.Presentation;
using Health_Tec.Models;

namespace Health_Tec.Mapping
{
    // Convierte los objetos que vienen desde la capa
    // de persistencia a objetos del Presentation Model
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Clinica, ClinicaResource>();
            CreateMap<Clinica, ClinicaResourceLite>();
            CreateMap<Medico, MedicoResource>();
            CreateMap<Medico, MedicoResourceLite>();
            CreateMap<Paciente, PacienteResource>();
            CreateMap<Paciente, PacienteResourceLite>();
            CreateMap<Estado, EstadoResource>();
            CreateMap<Telefono, TelefonoResource>();
        }
    }
}