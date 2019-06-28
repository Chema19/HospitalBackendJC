using NUnit.Framework;
using Hospital.Api.Controllers;
using Hospital.Entity;
using Hospital.Service.implementation;
using Hospital.Repositoy.implementation;
using System;
using static NUnit.Framework.Assert;
using System.Collections.Generic;
using Hospital.Repositoy.dbcontext;
using Hospital.Service;
using System.Linq;

namespace Hospital.Test
{
    [TestFixture]
    public class PacienteTest
    {
        private PacienteRepository pacienteRepository;
        private ApplicationDbContext context;

        [SetUp]
        public void Setup() {
            context = new ApplicationDbContext();
            pacienteRepository = new PacienteRepository();
        }

        [Test]
        public void AddPacienteTest()
        {
            try
            {
                Paciente paciente = new Paciente();

                paciente.Nombres = "Moritz";
                paciente.Apellidos = "Inga Villafuerte";
                paciente.Dni = "73876560";
                paciente.Telefono = "7916943";
                paciente.Direccion = "Jr. Independencia 563";

                var dato = pacienteRepository.Save(paciente);
                AreEqual(true, dato);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Test]
        public void EditPacienteTest()
        {
            try
            {
                Paciente paciente = new Paciente();

                paciente.Id = 4;
                paciente.Nombres = "Claudia";
                paciente.Apellidos = "Inga Villafuerte";
                paciente.Dni = "73876557";
                paciente.Telefono = "7916943";
                paciente.Direccion = "Jr. Independencia 563";

                var dato = pacienteRepository.Update(paciente);
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
                var lista = pacienteRepository.GetAll();

                AreEqual(6, lista.ToList().Count());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}