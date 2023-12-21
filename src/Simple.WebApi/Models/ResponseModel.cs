using System.Net;

namespace Simple.WebApi.Models;

public class ResponseModel
{
    public HttpStatusCode Status { get; set; }

    public Guid RequestId { get; set; }

    public object? Data { get; set; }

}

