namespace SIS.Models
{
    public class OsymInfo
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? UniversityName { get; set; }
        public string? Department { get; set; }
        public string? PointType { get; set; }
        public decimal Point { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? PlacementType { get; set; }
        public string? RegistrationAddress { get; set; }
        public int PlacementOrder { get; set; }
    }
}
