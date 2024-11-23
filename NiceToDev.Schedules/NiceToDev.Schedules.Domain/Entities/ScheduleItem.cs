namespace NiceToDev.Schedules.Domain.Entities
{
    public class ScheduleItem
    {
        #region Constructors

        public ScheduleItem()
        {
            
        }

        public ScheduleItem(Schedule schedule, string name)
        {
            Schedule = schedule;
            ScheduleId = schedule.Id;
            Name = name;
        }

        #endregion Constructors

        /// <summary>
        /// Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Parent schedule identifier
        /// </summary>
        public int ScheduleId { get; set; }

        /// <summary>
        /// Parent schedule object
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Item name
        /// </summary>
        public string Name { get; set; } = string.Empty;
    }
}
