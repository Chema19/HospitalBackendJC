using System.Collections;
using Hospital.Entity;

namespace Hospital.Service {
    public interface IMedicamentoService : IService<Medicamento> {
        IEnumerable fetchMedicamentoByName (string texto);
    }
}