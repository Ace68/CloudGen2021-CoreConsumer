using System;
using CloudGenCoreConsumer.Abstracts;

namespace CloudGenCoreConsumer.CustomTypes
{
    public sealed class StreamWhen : CustomTypeDate<StreamWhen>
    {
        public StreamWhen(DateTime value) : base(value)
        {
        }
    }
}