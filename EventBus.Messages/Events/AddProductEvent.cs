namespace EventBus.Messages.Events
{
    public class AddProductEvent : IntegrationBaseEvent
    {
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
    }
}
