using CloudGenCoreConsumer.Abstracts;

namespace CloudGenCoreConsumer.CustomTypes
{
    public sealed class EventId : CustomTypeString<EventId>
    {
        public EventId(string value) : base(value)
        {
        }
    }
}