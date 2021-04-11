using CloudGenCoreConsumer.Abstracts;

namespace CloudGenCoreConsumer.CustomTypes
{
    public sealed class UnitOfMeasurement : CustomTypeString<UnitOfMeasurement>
    {
        public UnitOfMeasurement(string value) : base(value)
        {
        }
    }
}