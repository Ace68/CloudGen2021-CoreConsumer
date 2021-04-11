using System.Linq;
using CloudGenCoreConsumer.Events;
using FourSolid.IoT.Shared.Events.Device;
using FourSolid.IoT.Shared.JsonModel;

namespace CloudGenCoreConsumer.Services
{
    public static class EventsConverter
    {
        public static DeviceValuesUpdated MapDeviceValuesUpdated(ThermometerValuesUpdated @event)
        {
            var lastValuesJson = new LastValuesJson
            {
                LastCommunicationDate = @event.CommunicationDate.Value,
                Sensors = Enumerable.Empty<SensorJson>()
            };

            return new DeviceValuesUpdated(@event.DeviceId, lastValuesJson, @event.Who, @event.When);
        }
    }
}