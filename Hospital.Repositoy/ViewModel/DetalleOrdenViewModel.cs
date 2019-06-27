namespace Hospital.Repositoy.ViewModel {
    public class DetalleOrdenViewModel {
        public int Id { get; set; }
        public int OrdenId { get; set; }
        public int MedicamentoId { get; set; }
        public string NombreMedicamento { get; set; }
        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

    }
}