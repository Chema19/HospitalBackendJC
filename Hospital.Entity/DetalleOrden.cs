namespace Hospital.Entity {
    public class DetalleOrden {
        public int Id { get; set; }

        public int Cantidad { get; set; }

        public int OrdenId { get; set; }
        public Orden Orden { get; set; }
        public Medicamento Medicamento { get; set; }
        public int MedicamentoId { get; set; }

    }
}