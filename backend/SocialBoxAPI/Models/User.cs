using System;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string Email { get; set; }

    public string AuthProvider { get; set; } 
    
    public string AuthUserId { get; set; } 
}
