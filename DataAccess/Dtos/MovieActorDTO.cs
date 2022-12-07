using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_examen_07449.DataAccess.Dtos
{
    [Table("MovieActors")]
    public class MovieActorDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int MovieId { get; set; }

        [Required]
        public int ActorId { get; set; }

        [ForeignKey("MovieID")]
        public MovieDTO Movie { get; set; }

        [ForeignKey("ActorID")]
        public ActorDTO Actor { get; set; }


        public MovieActorDTO(int movieId, int actorId) { 
            this.MovieId = movieId;
            this.ActorId = actorId;
        }
    }


}
