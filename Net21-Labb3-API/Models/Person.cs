using System.ComponentModel.DataAnnotations;

namespace Net21_Labb3_API.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<Interest>? Interests { get; set; }

        public List <Website>? Websites { get; set; }

    }
}
