using NiceToDev.Schedules.Domain.Entities;

namespace NiceToDev.Schedules.Domain.Interfaces
{
    public interface IScheduleRepository
    {
        /// <summary>
        /// Method to add a schedule
        /// </summary>
        /// <param name="schedule">Schedule object</param>
        void Add(Schedule schedule);

        /// <summary>
        /// Method to update a schedule
        /// </summary>
        /// <param name="schedule">Schedule object</param>
        void Update(Schedule schedule);

        /// <summary>
        /// Method to add an item to a schedule
        /// </summary>
        /// <param name="item">Schedule item object</param>
        void AddItem(ScheduleItem item);

        /// <summary>
        /// Method to update an item in a schedule
        /// </summary>
        /// <param name="item">Schedule item object</param>
        void UpdateItem(ScheduleItem item);

        /// <summary>
        /// Method to get a schedule by id
        /// </summary>
        /// <param name="id">Schedule identifier</param>
        /// <returns>Schedule object</returns>
        Schedule? GetScheduleById(int id);

        /// <summary>
        /// Method to get all schedules
        /// </summary>
        /// <returns>List of all schedules</returns>
        List<Schedule> GetAllSchedule();
    }
}
