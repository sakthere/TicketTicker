using System.ComponentModel.DataAnnotations;

namespace TickeTicker.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public String ProfilePictureURL { get; set; }
        public string Name { get; set; }
        public String Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
