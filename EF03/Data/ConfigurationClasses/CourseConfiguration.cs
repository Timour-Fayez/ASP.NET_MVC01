using EF03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF03.Data.ConfigurationClasses
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder
                  .HasKey(c => c.Id);

            
            builder
                  .HasOne(c => c.Department)
                  .WithMany(d => d.Courses)
                  .HasForeignKey(c => c.DepartmentId)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
