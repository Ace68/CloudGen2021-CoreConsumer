using System;
using CloudGenCoreConsumer.Abstracts;

namespace CloudGenCoreConsumer.CustomTypes
{
    public sealed class CommunicationDate : CustomTypeDate<CommunicationDate>
    {
        public CommunicationDate(DateTime value) : base(value)
        {
        }
    }
}