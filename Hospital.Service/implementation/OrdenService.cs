using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy;
using Hospital.Repositoy.ViewModel;

namespace Hospital.Service.implementation {
    public class OrdenService : IOrdenService {
        private IOrdenRepository ordenRepository;

        public OrdenService (IOrdenRepository ordenRepository) {
            this.ordenRepository = ordenRepository;
        }

        public bool Delete (int id) {
            throw new System.NotImplementedException ();
        }

        public Orden Get (int id) {
            throw new System.NotImplementedException ();
        }

        public IEnumerable<Orden> GetAll () {
            throw new System.NotImplementedException ();
        }

        public IEnumerable<OrdenViewModel> GetAllOrdenes () {
            return ordenRepository.GetAllOrdenes ();
        }

        public IEnumerable<DetalleOrdenViewModel> ListarDetalles (int ordenId) {
            return ordenRepository.ListarDetalles (ordenId);
        }

        public bool Save (Orden entity) {
            return ordenRepository.Save(entity);
        }

        public bool Update (Orden entity) {
            throw new System.NotImplementedException ();
        }
    }
}