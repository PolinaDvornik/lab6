using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace lab6.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassType> ClassTypes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // настраиваем тип удаления (no action) с помощью Fluent Api
            modelBuilder.Entity<Schedule>()
                .HasOne(o => o.Teacher).WithMany().OnDelete(DeleteBehavior.NoAction);

            /*
            DbDataConfigurator.FillModelArrays();

            modelBuilder.ApplyConfiguration(new ClassData());
            modelBuilder.ApplyConfiguration(new ClassTypeData());
            modelBuilder.ApplyConfiguration(new ScheduleData());
            modelBuilder.ApplyConfiguration(new StudentData());
            modelBuilder.ApplyConfiguration(new SubjectData());
            modelBuilder.ApplyConfiguration(new TeacherData());*/
        }
    }
}
