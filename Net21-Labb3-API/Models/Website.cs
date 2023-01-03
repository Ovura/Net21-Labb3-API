using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net21_Labb3_API.Models
{
    public class Website
    {
      
        public int Id { get; set; }
        public string? Descripton { get; set; }

        public int InterestId { get; set; }
        public Interest? Interest { get; set; }

        [Required]
        public string? Url { get; set; }
    }
}
