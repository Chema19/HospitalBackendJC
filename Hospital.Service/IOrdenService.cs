using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy.ViewModel;

namespace Hospital.Service {
    public interface IOrdenService : IService<Orden> {
        IEnumerable<OrdenViewModel> GetAllOrdenes ();

        IEnumerable<DetalleOrdenViewModel> ListarDetalles (int ordenId);
    }
}