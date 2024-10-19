using NiceToDev.Schedules.Domain.Entities;

namespace NiceToDev.Schedules.Application.Models
{
    public class ScheduleDto
    {
        public ScheduleDto(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<ScheduleItem> Items { get; set; } = new();
    }
}
