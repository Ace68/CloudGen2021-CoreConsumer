using CloudGenCoreConsumer.Abstracts;

namespace CloudGenCoreConsumer.CustomTypes
{
    public sealed class Temperature : CustomTypeBase<Temperature>
    {
        public readonly double Value;

        public Temperature(double value)
        {
            this.Value = value;
        }
    }
}