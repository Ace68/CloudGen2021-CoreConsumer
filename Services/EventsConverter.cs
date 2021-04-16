using System;
using System.Collections.Generic;
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
                Sensors = new List<SensorJson>
                {
                    new SensorJson
                    {
                        SensorId = Guid.NewGuid().ToString(),
                        Descriptions = new List<DescriptionJson>
                        {
                            new DescriptionJson
                            {
                                Code = "en",
                                Value = "Temperature"
                            }
                        },
                        SensorType = new SensorTypeJson
                        {
                            SensorTypeId = "c1af5cd2-392d-425c-b1c8-d947ca1910e0",
                            Description = "Value"
                        },
                        DataType = "string",
                        SensorValue = @event.Temperature.Value.ToString("F"),
                        SensorKey = "Temperature",
                        UnitOfMeasure = "°C",
                        ShowInGrid = false,
                        EnableFilterInGrid = false
                    }
                }
            };

            return new DeviceValuesUpdated(@event.DeviceId, lastValuesJson, @event.Who, @event.When);
        }
    }
}