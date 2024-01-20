using api.message.Domain.Base;
using api.message.Domain.Models.Settings;
using api.message.Domain.Ports.Outbound;
using Microsoft.Extensions.Options;

namespace api.message.Adapters.Outbound.SQLServer
{
    public class SQLServerService : ISQLServer
    {
        private readonly AppSettings _appSettings;
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;


        public SQLServerService(IServiceProvider serviceProvider)
        {
            _configuration = serviceProvider.GetRequiredService<IConfiguration>();
            _appSettings = _configuration.Get<AppSettings>();
            _connectionString = _appSettings.SQLServerSettings.ConnectionString;

        }

        public async Task<BaseReturn> SaveMessage()
        {
            return new BaseReturn().Success("Ok");
        }
    }
}
