using CloudGenCoreConsumer.Abstracts;

namespace CloudGenCoreConsumer.CustomTypes
{
    public sealed class StreamType : CustomTypeString<StreamType>
    {
        public StreamType(string value) : base(value)
        {
        }
    }
}