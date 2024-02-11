using System.ComponentModel.DataAnnotations.Schema;

namespace StreamingServicesAPI.Models
{
    public class Genre
    {
        [Column("Genre_id")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
