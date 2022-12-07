using mock_examen_07449.DataAccess.Contexts;
using mock_examen_07449.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_examen_07449.DataAccess.Daos
{
    public class ActorDAO
    {
        private ProjetContext context;


        public ActorDAO(ProjetContext context)
        {
            this.context = context;
        }

        public ActorDTO GetById(int id)
        {
            return this.context.Actors.Where(actor => actor.Id == id).Single();

        }

        public List<ActorDTO> GetAll() { 
            return this.context.Actors.ToList();
        }
    }
}
