using NiceToDev.Schedules.Application.Models;

namespace NiceToDev.Schedules.Application.Interfaces
{
    public interface IScheduleService
    {
        /// <summary>
        /// Method to add a schedule
        /// </summary>
        /// <param name="scheduleDto">Schedule object</param>
        /// <returns>Schedule identifier</returns>
        int AddSchedule(ScheduleDto scheduleDto);

        /// <summary>
        /// Method to update a schedule
        /// </summary>
        /// <param name="scheduleDto">Schedule object</param>
        void UpdateSchedule(ScheduleDto scheduleDto);

        /// <summary>
        /// Method to add an item to a schedule
        /// </summary>
        /// <param name="itemDto">Schedule item object</param>
        /// <returns>Schedule item identifier</returns>
        int AddScheduleItem(ScheduleItemDto itemDto);

        /// <summary>
        /// Method to update an item in a schedule
        /// </summary>
        /// <param name="itemDto">Schedule item object</param>
        void UpdateScheduleItem(ScheduleItemDto itemDto);

        /// <summary>
        /// Method to get a schedule by id
        /// </summary>
        /// <param name="id">Schedule identifier</param>
        /// <returns>Schedule object</returns>
        ScheduleDto? GetScheduleById(int id);

        /// <summary>
        /// Method to get a list of all schedules
        /// </summary>
        /// <returns>List of all schedules</returns>
        List<ScheduleDto> GetAllSchedules();
    }
}
