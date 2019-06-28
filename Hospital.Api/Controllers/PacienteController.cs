using Hospital.Entity;
using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {

        private IPacienteService pacienteService;

        public PacienteController(IPacienteService pacienteService)
        {
            this.pacienteService = pacienteService;
        }
        

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                pacienteService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Paciente paciente)
        {
            return Ok(
                SavePaciente(paciente)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Paciente paciente)
        {
            return Ok(
                EditPaciente(paciente)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                pacienteService.Delete(id)
            );
        }

        public bool SavePaciente(Paciente paciente)
        {
            var dato = pacienteService.Save(paciente);
            return pacienteService.Save(paciente);
        }

        public bool EditPaciente(Paciente paciente)
        {
            return pacienteService.Update(paciente);
        }

    }
}