using System.Collections.Generic;

namespace Hospital.Entity {
    public class Orden {
        public int Id { get; set; }
        public string OrdenNro { get; set; }

        public string PagoMetodo { get; set; }
        public decimal Total { get; set; }

        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public IEnumerable<DetalleOrden> DetalleOrden { get; set; }
    }
}