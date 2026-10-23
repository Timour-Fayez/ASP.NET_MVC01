using EF03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF03.Data.ConfigurationClasses
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
           

            builder
                .HasKey(d => d.Id);
           

            builder
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(d => d.MgrName)
                .HasMaxLength(100);
        }
    }
}
