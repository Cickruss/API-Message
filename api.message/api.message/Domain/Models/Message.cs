namespace api.message.Domain.Models
{
    public record Message
    {
        public long IdReceiver { get; set; }
        public long IdIssuer { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public Message()
        {
            
        }
    }
}
