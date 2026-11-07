using Microsoft.AspNetCore.Identity;

namespace Project_MVC_GeziDuragi.Models.Entities;

public class AppUser : IdentityUser
{
    public string FullName { get; set; } = null!;
}