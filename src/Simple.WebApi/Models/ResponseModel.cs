using System.Net;

namespace Simple.WebApi.Models;

public class ResponseModel
{
    public HttpStatusCode Status { get; set; }

    public Guid RequestId { get; set; }

    public object? Data { get; set; }

    public static ResponseModel CreateOkResponse(object? data = null)
    {
        var response = new ResponseModel();
        response.Status = HttpStatusCode.OK;
        response.RequestId = Guid.NewGuid();
        response.Data = data;
        return response;
    }
}

