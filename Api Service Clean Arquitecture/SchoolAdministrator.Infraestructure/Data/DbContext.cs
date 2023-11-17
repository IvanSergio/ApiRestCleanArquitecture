using Microsoft.EntityFrameworkCore;
using SchoolAdministrator.Core.Entities;
using SchoolAdministrator.Infraestructure.Data.Configurations;

namespace SchoolAdministrator.Infraestructure.Data
{
  public class AppDbContext : DbContext
  {
    public DbSet<School> Schools { get; set; }
    public DbSet<Classroom> Classrooms { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.ApplyConfiguration(new SchoolConfiguration());
      builder.ApplyConfiguration(new ClassroomConfiguration());
    }
  }
}
