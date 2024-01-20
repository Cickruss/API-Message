using api.message.Domain.Base;
using api.message.Domain.Models;
using api.message.Domain.Ports.UseCases;

namespace api.message.Domain.UseCases
{
    public class UseCaseSendMessageService : IUseCaseSendMessage
    {
        public async Task<BaseReturn> Execute(Message message)
        {
            return new BaseReturn().Success(message);
        }
    }
}
