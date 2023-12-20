using Microsoft.AspNetCore.Mvc;
using Simple.WebApi.Models;

namespace Simple.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ResponseModel.CreateOkResponse());
        }
    }
}