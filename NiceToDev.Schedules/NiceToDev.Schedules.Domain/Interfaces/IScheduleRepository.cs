using NiceToDev.Schedules.Domain.Entities;

namespace NiceToDev.Schedules.Domain.Interfaces
{
    public interface IScheduleRepository
    {
        void Add(Schedule schedule);

        void Update(Schedule schedule);

        void AddItem(ScheduleItem item);

        void UpdateItem(ScheduleItem item);

        Schedule? GetSchedule(int id);

        List<Schedule> GetScheduleList();
    }
}
