using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab6.Models.ModelsConfigurations
{
    public class ClassTypeData : IEntityTypeConfiguration<ClassType>
    {
        public void Configure(EntityTypeBuilder<ClassType> builder)
        {
            builder.HasData(DbDataConfigurator.ClassTypes);
        }
    }
}
