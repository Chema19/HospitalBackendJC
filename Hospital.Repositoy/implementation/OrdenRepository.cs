using System;
using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;
using Hospital.Repositoy.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repositoy.implementation {
    public class OrdenRepository : IOrdenRepository {
        private ApplicationDbContext context;

        public OrdenRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public OrdenRepository()
        {
            this.context = new ApplicationDbContext();
        }

        public bool Delete (int id) {
            throw new System.NotImplementedException ();
        }

        public Orden Get (int id) {
            throw new System.NotImplementedException ();
        }

        public IEnumerable<OrdenViewModel> GetAllOrdenes () {

            var orden = context.Ordenes
                .Include (o => o.Paciente)
                .OrderByDescending (o => o.Id)
                .Take (10)
                .ToList ();
            

            return orden.Select (o => new OrdenViewModel {
                Id = o.Id,
                    OrdenNro = o.OrdenNro,
                    PacienteId = o.PacienteId,
                    NombrePaciente = o.Paciente.Nombres,
                    Total = o.Total,
                    PagoMetodo = o.PagoMetodo
            }).ToList();
        }

        IEnumerable<Orden> IRepository<Orden>.GetAll () {
            throw new System.NotImplementedException ();
        }

        public IEnumerable<DetalleOrdenViewModel> ListarDetalles (int ordenId) {

            //LINQ : Language Integrated  Query
            var detalle = context.DetalleOrdenes
                .Include (m => m.Medicamento)
                .Where (d => d.OrdenId == ordenId)
                .ToList ();

            return detalle.Select (d => new DetalleOrdenViewModel {
                MedicamentoId = d.MedicamentoId,
                    NombreMedicamento = d.Medicamento.Name,
                    Cantidad = d.Cantidad,
                    Precio = d.Medicamento.Price
            });

        }

        public bool Save (Orden entity) {

            Orden orden = new Orden {
                PacienteId = entity.PacienteId,
                OrdenNro = entity.OrdenNro,
                PagoMetodo = entity.PagoMetodo,
                Total = entity.Total
            };
            try {
                context.Ordenes.Add (orden);
                context.SaveChanges ();
                var ordenId = orden.Id;
                if (entity.DetalleOrden !=  null)
                {
                    foreach (var item in entity.DetalleOrden.ToList())
                    {
                        DetalleOrden detalle = new DetalleOrden
                        {
                            OrdenId = ordenId,
                            MedicamentoId = item.MedicamentoId,
                            Cantidad = item.Cantidad
                        };
                        context.DetalleOrdenes.Add(detalle);
                    }
                }
                context.SaveChanges ();
            } catch (Exception ex) {
                return false;
            }
            return true;
        }

        public bool Update (Orden entity) {
            throw new System.NotImplementedException ();
        }

    }
}