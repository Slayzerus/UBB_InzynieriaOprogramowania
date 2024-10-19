using Mapster;
using NiceToDev.Schedules.Application.Interfaces;
using NiceToDev.Schedules.Application.Models;
using NiceToDev.Schedules.Database;
using NiceToDev.Schedules.Domain.Entities;
using NiceToDev.Schedules.Domain.Interfaces;

namespace NiceToDev.Schedules.Application.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;

        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public void Add(ScheduleDto scheduleDto)
        {
            var schedule = scheduleDto.Adapt<Schedule>();
            _scheduleRepository.Add(schedule);
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
