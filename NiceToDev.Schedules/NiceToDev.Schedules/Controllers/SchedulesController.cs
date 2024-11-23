using Microsoft.AspNetCore.Mvc;
using NiceToDev.Schedules.Application.Interfaces;
using NiceToDev.Schedules.Application.Models;

namespace NiceToDev.Schedules.Controllers
{
    public class SchedulesController : Controller
    {
        private readonly IScheduleService _scheduleService;

        public SchedulesController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpGet]
        [HttpGet("list")]
        public IActionResult List()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("schedule")]
        public IActionResult AddSchedule([FromBody] ScheduleDto scheduleDto)
        {
            return Ok();
        }

        [HttpPut]
        [Route("schedule")]
        public IActionResult UpdateSchedule([FromBody] ScheduleDto scheduleDto)
        {
            return Ok();
        }

        [HttpPost]
        [Route("schedule/{scheduleId}/item")]
        public IActionResult AddItem(int scheduleId, [FromBody] ScheduleItemDto scheduleItemDto)
        {
            return Ok();
        }

        [HttpPut]
        [Route("schedule/{scheduleId}/item")]
        public IActionResult UpdateItem(int scheduleId, [FromBody] ScheduleItemDto scheduleItemDto)
        {
            return Ok();
        }
    }
}
