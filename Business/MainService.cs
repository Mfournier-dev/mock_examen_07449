using mock_examen_07449.Business.Services;
using mock_examen_07449.DataAccess.Contexts;
using mock_examen_07449.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_examen_07449.Business
{
    public class MainService
    {
        private ProjetContext context;
        private MovieService movieService;
        private ActorService actorService;
        private MovieActorService movieActorService;


        private static MainService INSTANCE;

        private MainService() {
            this.context = new ProjetContext();
            this.movieService = new MovieService(this.context);
            this.actorService = new ActorService(this.context);
            this.movieActorService = new MovieActorService(this.context);
        }

        public static MainService GetInstance() {
            if (INSTANCE is null) { 
                INSTANCE = new MainService();
            }
            return INSTANCE;
        }


        public MovieService GetMovieService() { 
            return this.movieService;
        }

        public ActorService GetActorService() { 
            return this.actorService;
        }

        public MovieActorService GetMovieActorService() { 
            return this.movieActorService;
        }

        public void StartApplication() {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }

        public void EndApplication() {
            Application.Exit();
        }

    }
}
