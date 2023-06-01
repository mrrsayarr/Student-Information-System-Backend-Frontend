namespace SIS.Models
{
    public class StudentInternship
    {
        public int Id { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? StudentNo { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? InternshipPlaceName { get; set; }
        public string? AddressOfTheInternship { get; set; }
        public string? SubjectOfTheInternship { get; set; }
        public int? NumberOfDaysOfInternship { get; set; }
    }
}

