using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_examen_07449.DataAccess.Dtos
{
    [Table("Movies")]
    public class MovieDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Title { get; set; }

        [MaxLength(512)]
        public string Description { get; set; }

        [Required]
        public DateTime ReleasedDate { get; set; }

        public List<MovieActorDTO> MovieActors { get; set; }


        public MovieDTO(string title, DateTime releasedDate, string? description = null) {
            this.Title = title;
            this.ReleasedDate = releasedDate;
            this.Description = description;
        }
    }
}
