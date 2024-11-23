using Mapster;
using NiceToDev.Schedules.Application.Models;
using NiceToDev.Schedules.Domain.Entities;

namespace NiceToDev.Schedules.Application.Interfaces
{
    public interface IScheduleService
    {
        /// <summary>
        /// Method to add a schedule
        /// </summary>
        /// <param name="scheduleDto">Schedule object</param>
        void Add(ScheduleDto scheduleDto);

        /// <summary>
        /// Method to update a schedule
        /// </summary>
        /// <param name="scheduleDto">Schedule object</param>
        void Update(ScheduleDto scheduleDto);

        /// <summary>
        /// Method to add an item to a schedule
        /// </summary>
        /// <param name="itemDto">Schedule item object</param>
        void AddItem(ScheduleItemDto itemDto);

        /// <summary>
        /// Method to update an item in a schedule
        /// </summary>
        /// <param name="itemDto">Schedule item object</param>
        void UpdateItem(ScheduleItemDto itemDto);

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
