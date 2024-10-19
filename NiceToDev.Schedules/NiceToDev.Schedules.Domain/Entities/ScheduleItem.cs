namespace NiceToDev.Schedules.Domain.Entities
{
    public class ScheduleItem
    {
        public ScheduleItem(Schedule schedule)
        {
            Schedule = schedule;
            ScheduleId = schedule.Id;
        }

        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
