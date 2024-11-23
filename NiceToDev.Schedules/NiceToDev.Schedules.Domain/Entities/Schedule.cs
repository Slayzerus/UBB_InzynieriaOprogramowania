namespace NiceToDev.Schedules.Domain.Entities
{
    public class Schedule
    {
        #region Constructors

        public Schedule()
        {
            
        }

        public Schedule(string name)
        {
            Name = name;
        }

        #endregion Constructors

        /// <summary>
        /// Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Schedule name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// List of all schedule items
        /// </summary>
        public List<ScheduleItem> Items { get; set; } = new();
    }
}
