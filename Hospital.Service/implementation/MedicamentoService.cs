using System.Collections;
using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy;

namespace Hospital.Service.implementation {
    public class MedicamentoService : IMedicamentoService {
        private IMedicamentoRepository medicamentoRepository;
        public MedicamentoService (IMedicamentoRepository medicamentoRepository) {
            this.medicamentoRepository = medicamentoRepository;
        }

        public bool Delete (int id) {
            throw new System.NotImplementedException ();
        }

        public IEnumerable fetchMedicamentoByName(string texto)
        {
            return medicamentoRepository.fetchMedicamentoByName(texto);
        }

        public Medicamento Get (int id) {
            throw new System.NotImplementedException ();
        }

        public IEnumerable<Medicamento> GetAll () {
           return medicamentoRepository.GetAll();
        }

        public bool Save (Medicamento entity) {
            throw new System.NotImplementedException ();
        }

        public bool Update (Medicamento entity) {
            throw new System.NotImplementedException ();
        }
    }
}