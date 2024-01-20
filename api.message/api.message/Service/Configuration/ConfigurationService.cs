using api.message.Domain.Ports.UseCases;
using api.message.Domain.UseCases;

namespace api.message.Service.Configuration
{
    public class ConfigurationService
    {
        public void AddServices(WebApplicationBuilder builder) 
        {

            builder.Services.AddScoped<IUseCaseSendMessage, UseCaseSendMessageService>();
        }
    }
}
