﻿namespace NiceToDev.Schedules.Domain.Entities
{
    public class Schedule
    {
        public Schedule(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<ScheduleItem> Items { get; set; } = new();
    }
}
