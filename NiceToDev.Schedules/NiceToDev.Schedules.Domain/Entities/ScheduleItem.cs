﻿namespace NiceToDev.Schedules.Domain.Entities
{
    public class ScheduleItem
    {
        public ScheduleItem(Schedule schedule, string name)
        {
            Schedule = schedule;
            ScheduleId = schedule.Id;
            Name = name;
        }

        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
