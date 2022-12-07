using mock_examen_07449.DataAccess.Contexts;
using mock_examen_07449.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_examen_07449.DataAccess.Daos
{

    public class MovieDAO
    {
        private ProjetContext context;


        public MovieDAO(ProjetContext context)
        {
            this.context = context;
        }

        public MovieDTO GetById(int id) {
            return this.context.Movies.Where(movie => movie.Id == id).Single();
        }

        public List<MovieDTO> GetAll() {
            return this.context.Movies.ToList();
        }

        public MovieDTO Create(MovieDTO newmovie) { 
            this.context.Movies.Add(newmovie);
            this.context.SaveChanges();
            return newmovie;
        }

        public MovieDTO Update(MovieDTO movie) {
            this.context.Movies.Update(movie);
            this.context.SaveChanges();
            return movie;
        }

        public MovieDTO Delete(MovieDTO movie)
        {
            this.context.Movies.Remove(movie);
            this.context.SaveChanges();
            return movie;
        }
    }
}
