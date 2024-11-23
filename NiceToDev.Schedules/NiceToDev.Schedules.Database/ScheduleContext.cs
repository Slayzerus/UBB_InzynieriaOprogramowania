using Microsoft.EntityFrameworkCore;
using NiceToDev.Schedules.Domain.Entities;

namespace NiceToDev.Schedules.Database
{
    public class ScheduleContext : DbContext
    {
        public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options)
        {
        }

        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Schedule>().HasKey(x => x.Id);
            modelBuilder.Entity<Schedule>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<ScheduleItem>().HasKey(x => x.Id);
            modelBuilder.Entity<ScheduleItem>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<ScheduleItem>().HasOne(x => x.Schedule).WithMany(x => x.Items).HasForeignKey(x => x.ScheduleId);
        }
    }
}
