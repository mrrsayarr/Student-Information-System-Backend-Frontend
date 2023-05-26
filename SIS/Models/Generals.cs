namespace SIS.Models
{
    public class Generals
    {
        public int Id { get; set; }
        public string? StudentNo { get; set; }
        public string? LessonName { get; set; }
        public double? Midterm { get; set; }
        public double? Final { get; set; }
        public double? Average { get; set; }
        public bool? Pass { get; set; }
    }
}
