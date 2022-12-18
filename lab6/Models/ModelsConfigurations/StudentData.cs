using lab6.Models;
using lab6.Models.ModelsConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab7.Models.ModelsConfigurations
{
    public class StudentData : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(DbDataConfigurator.Students);
        }
    }
}
