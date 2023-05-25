using System.ComponentModel.DataAnnotations.Schema;

namespace SIS.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string? StudentNo { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }

        [NotMapped]
        public string Password { get; set; }

    }
}
