namespace NiceToDev.Schedules.Application.Models
{
    public class ScheduleItemDto
    {
        public ScheduleItemDto(ScheduleDto schedule, string name)
        {
            Schedule = schedule;
            ScheduleId = schedule.Id;
            Name = name;
        }

        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public ScheduleDto Schedule { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
