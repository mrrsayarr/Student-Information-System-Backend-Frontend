using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIS.Models
{
	
	public class Students
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Department { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? StudentNo { get; set; }
        public string? PhoneNumber { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        
        [DataType(DataType.Date)] 
        public DateTime RegistrationDate { get; set; }
        public string?  Gender { get;  set; }
        public string? IdentificationNumber { get;  set; }
    }
}
