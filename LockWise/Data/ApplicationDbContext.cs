using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LockWise.Data.Models;

namespace LockWise.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Folder> Folder { get; set; } = default!;

public DbSet<LockWise.Data.Models.PasswordEntry> PasswordEntry { get; set; } = default!;
}
