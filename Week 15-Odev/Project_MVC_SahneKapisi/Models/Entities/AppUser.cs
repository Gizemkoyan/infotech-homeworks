using Microsoft.AspNetCore.Identity;

namespace Project_MVC_SahneKapisi.Models.Entities;

public class AppUser : IdentityUser
{
    public string FullName { get; set; } = null!;
}