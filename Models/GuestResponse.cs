using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models;

public class GuestResponse {
    [Required(ErrorMessage = "PLease enter your name")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "PLean enter a valid Email")]
    [EmailAddress]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Please enter a valid phone number")]
    public int? Phone { get; set; }
    [Required(ErrorMessage = "Please select an option")]
    public bool? WillAttend { get; set; }
}

