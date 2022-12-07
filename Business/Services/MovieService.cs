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
    public class MovieService
    {
        private MovieDAO movieDAO;

        public MovieService(ProjetContext context) { 
            this.movieDAO = new MovieDAO(context);
        }

        public MovieDTO DeleteMovie(MovieDTO movie) {
            return this.movieDAO.Delete(movie);
            

        }

        public MovieDTO CreateNewMovie(string title, DateTime releasedDate, string? description = null) { 
            MovieDTO newMovie = new MovieDTO(title, releasedDate, description);
            return this.movieDAO.Create(newMovie);

        }

        public List<MovieDTO> GetAllMovies() {
            return this.movieDAO.GetAll();
        }

    }
}
