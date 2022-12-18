using lab6.Models;
using lab6.Models.ModelsConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lab7.Models.ModelsConfigurations
{
    public class ScheduleData : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasData(DbDataConfigurator.Schedules);
        }
    }
}
