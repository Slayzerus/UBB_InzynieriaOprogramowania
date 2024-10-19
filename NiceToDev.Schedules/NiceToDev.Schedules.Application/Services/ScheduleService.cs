using Mapster;
using NiceToDev.Schedules.Application.Interfaces;
using NiceToDev.Schedules.Application.Models;
using NiceToDev.Schedules.Database;
using NiceToDev.Schedules.Domain.Entities;
using NiceToDev.Schedules.Domain.Interfaces;
using System.Security.Cryptography;

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

        public void Update(ScheduleDto scheduleDto)
        {
            var schedule = scheduleDto.Adapt<Schedule>();
            _scheduleRepository.Update(schedule);           
            
        }

        public void AddItem(ScheduleItemDto itemDto)
        {
            var item = itemDto.Adapt<ScheduleItem>();
            _scheduleRepository.AddItem(item);
        }

        public void UpdateItem(ScheduleItemDto itemDto)
        {
            var item = itemDto.Adapt<ScheduleItem>();
            _scheduleRepository.UpdateItem(item);
        }

        public ScheduleDto? GetSchedule(int id)
        {
            Schedule? schedule = _scheduleRepository.GetSchedule(id);
            return schedule.Adapt<ScheduleDto?>();
        }

        public List<ScheduleDto> GetScheduleList()
        {
            List<Schedule> schedule = _scheduleRepository.GetScheduleList();
            return schedule.Adapt<List<ScheduleDto>>();
        }
    }
}
