using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repositoy.implementation
{
    public class ConsultaRepository : IConsultaRepository
    {
        private ApplicationDbContext context;

        public ConsultaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }



        public Consulta Get(int id)
        {
            var result = new Consulta();
            try
            {
                result = context.Consultas.Single(x => x.Id == id);
                
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Consulta> GetAll()
        {
             var result = new List<Consulta>();
            try
            {
                result = context.Consultas.Include(c => c.Paciente).ToList();

                result.Select(c => new Consulta
                {
                    Id= c.Id,
                    PacienteId =c.PacienteId,
                    Descripcion=c.Descripcion
                });
              
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Consulta entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Consulta entity)
        {
            try
            {
                 var consultaOrigina = context.Consultas.Single(
                     x => x.Id == entity.Id
                 );

                 consultaOrigina.Id=entity.Id;
                 consultaOrigina.Descripcion=entity.Descripcion;
                 consultaOrigina.PacienteId=entity.PacienteId;
                

                 context.Update(consultaOrigina);
                 context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}