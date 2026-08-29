using System.ComponentModel.DataAnnotations;

namespace Football.Models
{
    public class ChampoinsLeague
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Total { get; set; }

    }
}
