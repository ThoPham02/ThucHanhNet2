using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models;

public class Student {
    public string? StudentID { get; set; }
    public string? Fullname { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
    public string?  Email { get; set; }
    public DateOnly Birthday { get; set; }
    public int IsActive { get; set; }
}