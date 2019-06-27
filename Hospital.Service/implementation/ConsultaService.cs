using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy;

namespace Hospital.Service.implementation
{
    public class ConsultaService : IConsultaService
    {

        private IConsultaRepository consultaRepository;
        public ConsultaService(IConsultaRepository consultaRepository)
        {
            this.consultaRepository = consultaRepository;
        }
        
        public Consulta Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Consulta> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool Save(Consulta entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Consulta entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

    }
}