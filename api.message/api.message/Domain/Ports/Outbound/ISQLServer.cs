using api.message.Domain.Base;

namespace api.message.Domain.Ports.Outbound
{
    public interface ISQLServer
    {
        public Task<BaseReturn> SaveMessage();
    }
}
