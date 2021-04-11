using CloudGenCoreConsumer.Abstracts;

namespace CloudGenCoreConsumer.CustomTypes
{
    public sealed class DeviceName : CustomTypeString<DeviceName>
    {
        public DeviceName(string value) : base(value)
        {
        }
    }
}