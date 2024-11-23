using Microsoft.EntityFrameworkCore;
using NiceToDev.Schedules.Database;
using NiceToDev.Schedules.Domain.Entities;
using NiceToDev.Schedules.Domain.Interfaces;

namespace NiceToDev.Schedules.Interfaces.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ScheduleContext _scheduleContext;

        public ScheduleRepository(ScheduleContext scheduleContext)
        {
            _scheduleContext = scheduleContext;
        }

        #region Methods

        /// <summary>
        /// Method to add a schedule
        /// </summary>
        /// <param name="schedule">Schedule object</param>
        public void Add(Schedule schedule)
        {
            _scheduleContext.Schedules.Add(schedule);
            _scheduleContext.SaveChanges();
        }

        /// <summary>
        /// Method to update a schedule
        /// </summary>
        /// <param name="schedule">Schedule object</param>
        public void Update(Schedule schedule)
        {
            _scheduleContext.Schedules.Update(schedule);
            _scheduleContext.SaveChanges();
        }

        /// <summary>
        /// Method to add an item to a schedule
        /// </summary>
        /// <param name="item">Schedule item object</param>
        public void AddItem(ScheduleItem item)
        {
            _scheduleContext.ScheduleItems.Add(item);
            _scheduleContext.SaveChanges();
        }

        /// <summary>
        /// Method to update an item in a schedule
        /// </summary>
        /// <param name="item">Schedule item object</param>
        public void UpdateItem(ScheduleItem item)
        {
            _scheduleContext.ScheduleItems.Update(item);
            _scheduleContext.SaveChanges();
        }

        /// <summary>
        /// Method to get a schedule by id
        /// </summary>
        /// <param name="id">Schedule identifier</param>
        /// <returns>Schedule object</returns>
        public Schedule? GetScheduleById(int id)
        {
            return _scheduleContext.Schedules.Where(x => x.Id == id).Include(x => x.Items).FirstOrDefault();
        }

        /// <summary>
        /// Method to get all schedules
        /// </summary>
        /// <returns>List of all schedules</returns>
        public List<Schedule> GetAllSchedule()
        {
            return _scheduleContext.Schedules.ToList();
        }

        #endregion Methods
    }
}
