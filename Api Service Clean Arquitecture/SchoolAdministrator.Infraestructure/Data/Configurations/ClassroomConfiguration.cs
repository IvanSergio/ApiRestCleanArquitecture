using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolAdministrator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdministrator.Infraestructure.Data.Configurations
{
  public class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
  {
    public void Configure(EntityTypeBuilder<Classroom> builder)
    {
      builder
          .HasKey(x => x.Id);

      //builder
      //    .Property(x => x.Id)
      //    .UseIdentityColumn();
      builder.Property(e => e.Id).ValueGeneratedOnAdd();

      builder
          .Property(x => x.Name)
          .IsRequired()
          .HasMaxLength(255);

      builder
          .Property(x => x.Capacity)
          .IsRequired();

      builder
          .HasOne(x => x.School)
          .WithMany(y => y.Classrooms)
          .HasForeignKey(x => x.SchoolId);

      builder
          .ToTable("Classrooms");
    }
  }
}
