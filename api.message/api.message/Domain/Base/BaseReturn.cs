using System.Net;

namespace api.message.Domain.Base
{
    public record BaseReturn
    {
        public object? Body;
        public BaseError? Error;
        public HttpStatusCode StatusCode = HttpStatusCode.OK;


        public BaseReturn()
        {
            
        }
        public void HttpSuccess<TBody>(TBody successObject)
        {
            Body = successObject;
        }
        public BaseReturn Success(object successObject)
        {
            Body = successObject;

            return this;
        }
        public BaseReturn ErrorBusiness(string message, string stack)
        {
            StatusCode = HttpStatusCode.BadRequest;

            Error = new()
            {
                code = "400",
                message = $"{message}",
                info = stack,
            };

            return this;
        }
        public IResult GetResponse()
        {
            if (StatusCode is HttpStatusCode.OK) return Results.Ok(Body);
            return Results.Json(Error, statusCode: (int)StatusCode);
        }
        public BaseReturn ErrorSystem(Exception ex)
        {
            StatusCode = HttpStatusCode.InternalServerError;

            Error = new()
            {
                code = "500",
                message = $"System Error: {ex.Message}",
                info = ex.StackTrace,
            };

            return this;
        }

        public object? GetBody()
        {
            if (StatusCode is HttpStatusCode.OK) return Body;
            return Error;
        }
    }
}
