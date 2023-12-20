using System.Net;

namespace Simple.WebApi;

public class ResponseModel
{
    public HttpStatusCode Status { get; set; }

    public string RequestId { get; set; }

    public object? Data { get; set; }

    public static ResponseModel CreateOkResponse(object? data = null)
    {
        var response = new ResponseModel();
        response.Status = HttpStatusCode.OK;
        response.Data = data;
        return response;
    }
}

