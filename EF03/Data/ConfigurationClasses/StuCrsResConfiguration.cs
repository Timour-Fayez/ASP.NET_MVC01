using EF03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF03.Data.ConfigurationClasses
{
    public class StuCrsResConfiguration : IEntityTypeConfiguration<StuCrsRes>
    {
        public void Configure(EntityTypeBuilder<StuCrsRes> builder)
        {
            builder
                .HasKey(scr => new { scr.StudentId, scr.CourseId });

            builder
                .Property(scr => scr.Grade)
                .HasColumnType("decimal(5,2)");

           
            builder
                .HasOne(scr => scr.Student)
                .WithMany(s => s.StuCrsRes)
                .HasForeignKey(scr => scr.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(scr => scr.Course)
                .WithMany(c => c.StuCrsRes)
                .HasForeignKey(scr => scr.CourseId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
