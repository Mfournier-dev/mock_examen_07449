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
    public class MovieActorService
    {
        private MovieActorDAO movieActorDAO;


        public MovieActorService(ProjetContext context) {
            this.movieActorDAO = new MovieActorDAO(context);
        }

        public List<ActorDTO> GetAllActorsForMovie(int movieId) {
            return movieActorDAO.GetAllActorsForMovie(movieId);
        }


        public MovieActorDTO CreateNewMovieActorsLink(int movieId, int actorId) { 
            MovieActorDTO movieActorDTO = new MovieActorDTO(movieId, actorId);
            this.movieActorDAO.Create(movieActorDTO);
            return movieActorDTO;
        }

        public MovieActorDTO DeleteMovieActorLink(int movieId, int actorId) {
          return this.movieActorDAO.Delete(this.movieActorDAO.GetByMovieAndActor(movieId, actorId));

        }

    }
}
