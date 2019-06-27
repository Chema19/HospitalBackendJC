using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy.ViewModel;

namespace Hospital.Repositoy {
    public interface IOrdenRepository : IRepository<Orden> {
        IEnumerable<OrdenViewModel> GetAllOrdenes ();

        IEnumerable<DetalleOrdenViewModel> ListarDetalles (int ordenId);
    }
}