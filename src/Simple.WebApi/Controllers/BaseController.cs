using System.Net;
using Microsoft.AspNetCore.Mvc;
using Simple.WebApi.Models;

namespace Simple.WebApi.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public BaseController(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public override OkObjectResult Ok(object? value)
        {
            var reqID = Guid.Empty;

            if (httpContextAccessor.HttpContext != null && httpContextAccessor.HttpContext.Items.ContainsKey("RequestId"))
                Guid.TryParse(Convert.ToString(httpContextAccessor.HttpContext.Items["RequestId"]), out reqID);

            var response = new ResponseModel()
            {
                Status = HttpStatusCode.OK,
                RequestId = reqID,
                Data = value
            };
            return base.Ok(response);
        }
    }
}
