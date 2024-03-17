using Microsoft.AspNetCore.Mvc;
using Service.DTOs;
using Service.Services.Interfaces;

namespace Fiorello_app.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SliderController : Controller
    {
        private readonly ISliderService _service;

        public SliderController(ISliderService service)
        {
            _service = service;
        }
        [HttpGet]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(IEnumerable<SliderDto>))]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }
    }
}
