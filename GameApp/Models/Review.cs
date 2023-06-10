using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameApp.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }

        public string User { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        public string ReviewMessage { get; set; }
    }
}
