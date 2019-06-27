using System.Collections;
using Hospital.Entity;

namespace Hospital.Repositoy {
    public interface IMedicamentoRepository : IRepository<Medicamento> {

        IEnumerable fetchMedicamentoByName (string texto);

    }
}