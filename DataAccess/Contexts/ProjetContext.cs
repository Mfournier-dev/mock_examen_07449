using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using mock_examen_07449.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_examen_07449.DataAccess.Contexts
{
    public class ProjetContext : DbContext
    {

        public DbSet<MovieDTO> Movies { get; set; }

        public DbSet<ActorDTO> Actors { get; set; }
        public DbSet<MovieActorDTO> MovieActors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlServer(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
            options.LogTo(Console.WriteLine);
        }
    }
}
