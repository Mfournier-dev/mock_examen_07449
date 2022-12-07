using Microsoft.EntityFrameworkCore;
using mock_examen_07449.DataAccess.Contexts;
using mock_examen_07449.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_examen_07449.DataAccess.Daos
{
    public class MovieActorDAO
    {
        private ProjetContext context;

        public MovieActorDAO(ProjetContext context)
        {
            this.context = context;
        }



        public MovieActorDTO GetByMovieAndActor(int movieId, int actorID) {
            return this.context.MovieActors.Where(movAct => movAct.MovieId == movieId && movAct.ActorId == actorID).Single();
        }

        public MovieActorDTO Create(MovieActorDTO movieActor)
        {
            this.context.MovieActors.Add(movieActor);
            this.context.SaveChanges();
            return movieActor;

        }

        public MovieActorDTO Delete(MovieActorDTO movieActor)
        {
            this.context.MovieActors.Remove(movieActor);
            this.context.SaveChanges();
            return movieActor;

        }

        public List<ActorDTO> GetAllActorsForMovie(int movieId) {
            List<MovieActorDTO> movieActorLinks = this.context.MovieActors
                .Where(movAct => movAct.MovieId == movieId)
                .Include(movAct => movAct.Actor)
                .ToList();

            List<ActorDTO> actorsList = new List<ActorDTO>();
            foreach (MovieActorDTO movActorLink in movieActorLinks)
            {
                ActorDTO actor = movActorLink.Actor;
                if (!actorsList.Contains(actor))
                {
                    actorsList.Add(actor);
                }
                
            }
            return actorsList;
        }

    }
}
