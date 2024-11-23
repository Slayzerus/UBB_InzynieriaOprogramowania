using Mapster;
using NiceToDev.Schedules.Application.Interfaces;
using NiceToDev.Schedules.Application.Models;
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

        #region Methods

        /// <summary>
        /// Method to add a schedule
        /// </summary>
        /// <param name="scheduleDto">Schedule object</param>
        /// <returns>Schedule identifier</returns>
        public int AddSchedule(ScheduleDto scheduleDto)
        {
            var schedule = scheduleDto.Adapt<Schedule>();
            _scheduleRepository.AddSchedule(schedule);
            return schedule.Id;
        }

        /// <summary>
        /// Method to update a schedule
        /// </summary>
        /// <param name="scheduleDto">Schedule object</param>
        public void UpdateSchedule(ScheduleDto scheduleDto)
        {
            var schedule = scheduleDto.Adapt<Schedule>();
            _scheduleRepository.UpdateSchedule(schedule);
        }

        /// <summary>
        /// Method to add an item to a schedule
        /// </summary>
        /// <param name="itemDto">Schedule item object</param>
        /// <returns>Schedule item identifier</returns>
        public int AddScheduleItem(ScheduleItemDto itemDto)
        {
            var item = itemDto.Adapt<ScheduleItem>();
            _scheduleRepository.AddScheduleItem(item);
            return item.Id;
        }

        /// <summary>
        /// Method to update an item in a schedule
        /// </summary>
        /// <param name="itemDto">Schedule item object</param>
        public void UpdateScheduleItem(ScheduleItemDto itemDto)
        {
            var item = itemDto.Adapt<ScheduleItem>();
            _scheduleRepository.UpdateScheduleItem(item);
        }

        /// <summary>
        /// Method to get a schedule by id
        /// </summary>
        /// <param name="id">Schedule identifier</param>
        /// <returns>Schedule object</returns>
        public ScheduleDto? GetScheduleById(int id)
        {
            Schedule? schedule = _scheduleRepository.GetScheduleById(id);
            if (schedule != null)
            {
                return schedule.Adapt<ScheduleDto>();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Method to get a list of all schedules
        /// </summary>
        /// <returns>List of all schedules</returns>
        public List<ScheduleDto> GetAllSchedules()
        {
            List<Schedule> scheduleDtos = _scheduleRepository.GetAllSchedules();
            return scheduleDtos.Adapt<List<ScheduleDto>>();
        }

        #endregion Methods
    }
}
