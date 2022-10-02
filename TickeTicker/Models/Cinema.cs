using System.ComponentModel.DataAnnotations;

namespace TickeTicker.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public String ProfilePictureURL { get; set; }
        public string Name { get; set; }
        public String Description { get; set; }
    }
}
