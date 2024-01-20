using api.message.Domain.Base;
using api.message.Domain.Models;

namespace api.message.Domain.Ports.UseCases
{
    public interface IUseCaseSendMessage
    {
        public Task<BaseReturn> Execute(Message message);
    }
}
