using System.ComponentModel.DataAnnotations;

namespace VuHongNgocBTH2.Models
{
    public class Faculty
    {
        [Key]
        public string? FacultyID {get; set;}
        
        public string? FacultyName {get; set;}
    }
}