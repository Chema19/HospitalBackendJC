using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation {
    public class MedicamentoRepository : IMedicamentoRepository {

        private ApplicationDbContext context;

        public MedicamentoRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Delete (int id) {
            throw new System.NotImplementedException ();
        }

        public IEnumerable fetchMedicamentoByName (string texto) {
            var result = new List<Medicamento> ();
            try {
                result = context.Medicamentos.Where(m=> m.Name.Contains(texto)).ToList ();
            } catch (System.Exception) {

                throw;
            }
            return result;
        }

        public Medicamento Get (int id) {
            var result = new Medicamento ();
            try {
                result = context.Medicamentos.Single (x => x.Id == id);
            } catch (System.Exception) {

                throw;
            }
            return result;
        }

        public IEnumerable<Medicamento> GetAll () {
            var result = new List<Medicamento> ();
            try {
                result = context.Medicamentos.ToList ();
            } catch (System.Exception) {

                throw;
            }
            return result;
        }

        public bool Save (Medicamento entity) {
            throw new System.NotImplementedException ();
        }

        public bool Update (Medicamento entity) {
            throw new System.NotImplementedException ();
        }
    }
}