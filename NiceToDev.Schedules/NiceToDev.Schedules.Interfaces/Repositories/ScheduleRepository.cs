using Microsoft.EntityFrameworkCore;
using NiceToDev.Schedules.Database;
using NiceToDev.Schedules.Domain.Entities;
using NiceToDev.Schedules.Domain.Interfaces;

namespace NiceToDev.Schedules.Interfaces.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ScheduleContext _scheduleContext;

        public ScheduleRepository(ScheduleContext scheduleContext)
        {
            _scheduleContext = scheduleContext;
        }

        public void Add(Schedule schedule)
        {
            _scheduleContext.Schedules.Add(schedule);
            _scheduleContext.SaveChanges();
        }

        public void Update(Schedule schedule)
        {
            _scheduleContext.Schedules.Update(schedule);
            _scheduleContext.SaveChanges();
        }

        public void AddItem(ScheduleItem item)
        {
            _scheduleContext.ScheduleItems.Add(item);
            _scheduleContext.SaveChanges();
        }

        public void UpdateItem(ScheduleItem item)
        {
            _scheduleContext.ScheduleItems.Update(item);
            _scheduleContext.SaveChanges();
        }

        public Schedule? GetSchedule(int id)
        {
            return _scheduleContext.Schedules.Where(x => x.Id == id).Include(x => x.Items).FirstOrDefault();
        }

        public List<Schedule> GetScheduleList()
        {
            return _scheduleContext.Schedules.ToList();
        }
    }
}
