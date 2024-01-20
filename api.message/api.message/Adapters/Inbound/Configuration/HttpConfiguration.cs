using api.message.Domain.Ports.Inbound.UseCases;
using api.message.Domain.UseCases;

namespace api.message.Adapters.Inbound.Configuration
{
    public class HttpConfiguration
    {
        public void AddUseCases(IServiceProvider provider)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();

            builder.Services.AddScoped<IUseCaseSendMessage, UseCaseSendMessageService>();
        }
    }
}
