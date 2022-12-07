using mock_examen_07449.DataAccess.Contexts;
using mock_examen_07449.DataAccess.Daos;
using mock_examen_07449.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_examen_07449.Business.Services
{
    public class ActorService
    {
        private ActorDAO actorDAO;

        public ActorService(ProjetContext context)
        {
            this.actorDAO = new ActorDAO(context);

        }

        public List<ActorDTO> GetAllActors()
        {
            return this.actorDAO.GetAll();
        }
    }
}
