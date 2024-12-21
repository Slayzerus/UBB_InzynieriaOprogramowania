using Microsoft.AspNetCore.Mvc;
using NiceToDev.Schedules.Application.Interfaces;
using NiceToDev.Schedules.Application.Models;

namespace NiceToDev.Schedules.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchedulesController : ControllerBase
    {
        private readonly IScheduleService _scheduleService;
        private readonly ILogger<SchedulesController> _logger;

        public SchedulesController(IScheduleService scheduleService, ILogger<SchedulesController> logger)
        {
            _scheduleService = scheduleService;
            _logger = logger;
        }

        // Route: GET api/schedules
        [HttpGet]
        public IActionResult List()
        {
            return Ok();
        }

        // Route: GET api/schedules/list
        [HttpGet("list")]
        public IActionResult ListDetailed()
        {
            return Ok();
        }

        // Route: GET api/schedules/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        // Route: POST api/schedules/schedule
        [HttpPost("schedule")]
        public IActionResult AddSchedule([FromBody] ScheduleDto scheduleDto)
        {
            int id = _scheduleService.AddSchedule(scheduleDto);
            return Ok(id);
        }

        // Route: PUT api/schedules/schedule
        [HttpPut("schedule")]
        public IActionResult UpdateSchedule([FromBody] ScheduleDto scheduleDto)
        {
            return Ok();
        }

        // Route: POST api/schedules/schedule/{scheduleId}/item
        [HttpPost("schedule/{scheduleId}/item")]
        public IActionResult AddItem(int scheduleId, [FromBody] ScheduleItemDto scheduleItemDto)
        {
            return Ok();
        }

        // Route: PUT api/schedules/schedule/{scheduleId}/item
        [HttpPut("schedule/{scheduleId}/item")]
        public IActionResult UpdateItem(int scheduleId, [FromBody] ScheduleItemDto scheduleItemDto)
        {
            return Ok();
        }
    }
}
