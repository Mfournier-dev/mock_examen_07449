using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mock_examen_07449.DataAccess.Dtos
{
    [Table("Actors")]
    public class ActorDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(48)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(48)]
        public string LastName { get; set; }
        [MaxLength(128)]
        public string ProfessionalName { get; set; }


        public List<MovieActorDTO> MovieActors { get; set; }
    }
}
