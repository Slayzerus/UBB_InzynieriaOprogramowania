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
        public void Add(ScheduleDto scheduleDto)
        {
            var schedule = scheduleDto.Adapt<Schedule>();
            _scheduleRepository.Add(schedule);
        }

        /// <summary>
        /// Method to update a schedule
        /// </summary>
        /// <param name="scheduleDto">Schedule object</param>
        public void Update(ScheduleDto scheduleDto)
        {
            var schedule = scheduleDto.Adapt<Schedule>();
            _scheduleRepository.Update(schedule);
        }

        /// <summary>
        /// Method to add an item to a schedule
        /// </summary>
        /// <param name="itemDto">Schedule item object</param>
        public void AddItem(ScheduleItemDto itemDto)
        {
            var item = itemDto.Adapt<ScheduleItem>();
            _scheduleRepository.AddItem(item);
        }

        /// <summary>
        /// Method to update an item in a schedule
        /// </summary>
        /// <param name="itemDto">Schedule item object</param>
        public void UpdateItem(ScheduleItemDto itemDto)
        {
            var item = itemDto.Adapt<ScheduleItem>();
            _scheduleRepository.UpdateItem(item);
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
            List<Schedule> scheduleDtos = _scheduleRepository.GetAllSchedule();
            return scheduleDtos.Adapt<List<ScheduleDto>>();
        }

        #endregion Methods
    }
}
