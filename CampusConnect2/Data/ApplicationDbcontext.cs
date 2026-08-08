using Microsoft.EntityFrameworkCore;
using CampusConnect2.Models;

namespace CampusConnect2.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Meeting> Meetings { get; set; }
}
