using api.message.Domain.Base;
using api.message.Domain.Models;

namespace api.message.Domain.Ports.Inbound.UseCases
{
    public interface IUseCaseSendMessage
    {
        public Task<BaseReturn> Execute(Message message);
    }
}
