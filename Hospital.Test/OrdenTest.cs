using Hospital.Entity;
using Hospital.Repositoy.dbcontext;
using Hospital.Repositoy.implementation;
using Hospital.Repositoy.ViewModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static NUnit.Framework.Assert;

namespace Hospital.Test
{
    [TestFixture]
    public class OrdenTest
    {

        private OrdenRepository ordenRepository;
        private ApplicationDbContext context;

        [SetUp]
        public void Setup()
        {
            context = new ApplicationDbContext();
            ordenRepository = new OrdenRepository();
        }

        [Test]
        public void AddOrdenTest()
        {
            try
            {
                Orden orden = new Orden();

                orden.OrdenNro = "3";
                orden.PagoMetodo = "Efectivo";
                orden.Total = 5;
                orden.PacienteId = 3;

                var dato = ordenRepository.Save(orden);
                AreEqual(true, dato);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Test]
        public void GetPacientesTest()
        {
            try
            {
                IEnumerable<OrdenViewModel> lista = ordenRepository.GetAllOrdenes();

                AreEqual(8, lista.Count());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
