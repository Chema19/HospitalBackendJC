using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers {

    [Route ("api/[controller]")]
    [ApiController]
    public class MedicamentoController : ControllerBase {

        private IMedicamentoService medicamentoService;

        public MedicamentoController (IMedicamentoService medicamentoService) {
            this.medicamentoService = medicamentoService;
        }

        [HttpGet]
        public ActionResult Get () {
            return Ok (
                medicamentoService.GetAll ()
            );
        }

        [HttpGet ("{texto}")]
        public ActionResult FecthMedicamentoByName ([FromRoute] string texto) {
            return Ok (
                medicamentoService.fetchMedicamentoByName(texto)
            );
        }
    }
}