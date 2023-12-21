using Microsoft.AspNetCore.Mvc;

namespace Simple.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : BaseController
    {
        public UserController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor) { }

        [HttpGet]
        public IActionResult Get()
        {
            var data = new { FirstName = "John", LastName = "Samantaray", Email = "john@gmail.com" };
            return Ok(data);
        }
    }
}