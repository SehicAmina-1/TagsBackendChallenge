using Amina.Models;
using Microsoft.EntityFrameworkCore;

namespace Amina.Controllers;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Tag> Tags { get; set; }
}