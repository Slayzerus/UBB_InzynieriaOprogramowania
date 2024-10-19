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
    }
}
