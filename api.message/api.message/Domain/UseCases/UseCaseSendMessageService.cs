using api.message.Domain.Base;
using api.message.Domain.Models;
using api.message.Domain.Ports.Inbound.UseCases;
using api.message.Domain.Ports.Outbound;

namespace api.message.Domain.UseCases
{
    public class UseCaseSendMessageService : IUseCaseSendMessage
    {
        private readonly ISQLServer _sql;

        public UseCaseSendMessageService(IServiceProvider service)
        {
            _sql = service.GetRequiredService<ISQLServer>();
        }
        public async Task<BaseReturn> Execute(Message message)
        {
            return new BaseReturn().Success(message);
        }
    }
}
