using lab6.Models;
using lab6.Models.ModelsConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab7.Models.ModelsConfigurations
{
    public class TeacherData : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(DbDataConfigurator.Teachers);
        }
    }
}
