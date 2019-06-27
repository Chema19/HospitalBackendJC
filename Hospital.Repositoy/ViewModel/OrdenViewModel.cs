using System.Collections.Generic;

namespace Hospital.Repositoy.ViewModel {
    public class OrdenViewModel {

        public int Id { get; set; }
        public string OrdenNro { get; set; }
        public int PacienteId { get; set; }
        public string NombrePaciente { get; set; }
        public string PagoMetodo { get; set; }
        public decimal Total { get; set; }

        public IEnumerable<DetalleOrdenViewModel> DetalleOrden { get; set; }

    }
}