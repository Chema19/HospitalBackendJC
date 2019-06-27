using Hospital.Entity;
using Hospital.Repositoy.ViewModel;
using Hospital.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers {

    [Route ("api/[controller]")]
    [ApiController]
    public class OrdenController : ControllerBase {

        private IOrdenService ordenService;

        public OrdenController (IOrdenService ordenService) {
            this.ordenService = ordenService;
        }

        [HttpGet]
        public ActionResult Get () {
            return Ok (
                ordenService.GetAllOrdenes ()
            );
        }

        [HttpGet ("{ordenId}")]
        public ActionResult GetDetalleOrden ([FromRoute] int ordenId) {
            return Ok (
                ordenService.ListarDetalles (ordenId)
            );
        }

        [HttpPost]
        public ActionResult CrearOrden ([FromBody] Orden model) {
            return Ok (
                ordenService.Save(model)
            );
        }

    }
}