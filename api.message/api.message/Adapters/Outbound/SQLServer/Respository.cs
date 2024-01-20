using api.message.Domain.Enums;
using api.message.Domain.Models;

namespace api.message.Adapters.Outbound.SQLServer
{
    public record Respository : Message
    {
        public EnumState state { get; set; }
    }
}
