using System.ComponentModel.DataAnnotations;

namespace Football.Models
{
    public class Club
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? City { get; set; }


    }
}
