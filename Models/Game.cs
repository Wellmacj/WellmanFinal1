using System.ComponentModel.DataAnnotations;

namespace WellmanFinal1.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public int Rating { get; set; }

        public int HoursPlayed { get; set; }
    }
}