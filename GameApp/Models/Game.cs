using GameApp.Models;
using System.ComponentModel.DataAnnotations;

namespace GameApp.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string? Genre { get; set; }

        public decimal Price { get; set; }

        public List<Review>? Reviews { get; set; }
    }
}