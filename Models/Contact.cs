using System.ComponentModel.DataAnnotations;

namespace ExercicesASP.NET.Models;

public class Contact
{
    public int Id { get; set; }

    [Display(Name = "First Name")]
    public string FirstName { get; set; } = string.Empty;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = string.Empty;

    [Display(Name = "Email Address")]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Display(Name = "Phone Number")]
    [Phone]
    public string PhoneNumber { get; set; } = string.Empty;
} 