using lab6.Models;
using lab6.Models.ModelsConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab7.Models.ModelsConfigurations
{
    public class SubjectData : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData(DbDataConfigurator.Subjects);
        }
    }
}
