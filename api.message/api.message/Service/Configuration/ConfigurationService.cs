using api.message.Adapters.Outbound.SQLServer;
using api.message.Domain.Models.Settings;
using api.message.Domain.Ports.Inbound.UseCases;
using api.message.Domain.Ports.Outbound;
using api.message.Domain.UseCases;

namespace api.message.Service.Configuration
{
    public class ConfigurationService
    {
        private readonly IConfiguration _configuration;
        private readonly IServiceCollection _service;

        public ConfigurationService(IServiceCollection services,IConfiguration configuration)
        {
            _configuration = configuration;
            _service = services;

        }
        public void AddServices() 
        {

            #region AppSetings
            _service.Configure<AppSettings>(_configuration);
            _service.Configure<SQLServerSettings>(_configuration.GetSection("SQLServerSettings"));
            #endregion

            #region UseCases

            _service.AddScoped<IUseCaseSendMessage, UseCaseSendMessageService>();

            #endregion

            #region Repositorys

            _service.AddScoped<ISQLServer, SQLServerService>();

            #endregion
        }

    }
}
