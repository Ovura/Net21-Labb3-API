using System.ComponentModel.DataAnnotations;

namespace Net21_Labb3_API.Models
{
    public class Interest
    {
        public int InterestId { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; } = null;

        public int Id { get; set; }
        public Person? Person { get; set; }

        public List<Website>? Websites { get;}
    }
}
