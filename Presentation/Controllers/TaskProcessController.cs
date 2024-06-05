using Application.Services.Interfaces;
using Domain.Models.Creates;
using Domain.Models.Filters;
using Domain.Models.Pagination;
using Domain.Models.Updates;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskProcessController : ControllerBase
    {
        private readonly ITaskCheckListReportService _taskCheckListReportService;
        public TaskProcessController(ITaskCheckListReportService taskCheckListReportService)
        {
            _taskCheckListReportService = taskCheckListReportService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTaskCheckListReports([FromQuery] TaskCheckListReportFilterModel filter, [FromQuery] PaginationRequestModel pagination)
        {
            try
            {
                return await _taskCheckListReportService.GetTaskCheckListReports(filter, pagination);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetTaskCheckListReport([FromRoute] Guid id)
        {
            try
            {
                return await _taskCheckListReportService.GetTaskCheckListReport(id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateTaskCheckListReport([FromBody] TaskCheckListReportCreateModel model)
        {
            try
            {
                return await _taskCheckListReportService.CreateTaskCheckListReport(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateTaskCheckListReport([FromRoute] Guid id, [FromBody] TaskCheckListReportUpdateModel model)
        {
            try
            {
                return await _taskCheckListReportService.UpdateTaskCheckListReport(id, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
