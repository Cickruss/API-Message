using api.message.Domain.Base;
using api.message.Domain.Models;
using api.message.Domain.Ports.Inbound.UseCases;

namespace api.message.Adapters.Inbound.Http
{
    public static class HttpRoute
    {
        public static void AddHttpRoute(this WebApplication app)
        {
            app.MapPost("/send", PostMessage);
        }
        public async static Task<IResult> PostMessage(IUseCaseSendMessage _useCase, HttpContext context, Message request)
        {
            try
            {
                var response = await _useCase.Execute(request);
                return response.GetResponse();
            }
            catch (Exception ex)
            {
                return new BaseReturn().ErrorSystem(ex).GetResponse();
            }
        }
    }
}
