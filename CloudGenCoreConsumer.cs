using CloudGenCoreConsumer.Events;
using CloudGenCoreConsumer.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CloudGenCoreConsumer
{
    public static class CloudGenCoreConsumer
    {
        [FunctionName("CloudGenCoreConsumer")]
        [return: ServiceBus("devicevaluesupdated", Connection = "ServiceBusCoreConnection")]
        public static string Run([ServiceBusTrigger("thermometervaluesupdated", "Azure-Subscription",
                Connection = "ServicesBusConnection")]
            string messageBody, ILogger log)
        {
            log.LogInformation($"Deserialize Thermometer @event {messageBody}");
            var thermometerValuesUpdated = JsonConvert.DeserializeObject<ThermometerValuesUpdated>(messageBody);

            log.LogInformation("Convert ThermometerValuesUpdated in DeviceValuesUpdated");
            var deviceValuesUpdated = EventsConverter.MapDeviceValuesUpdated(thermometerValuesUpdated);

            return JsonConvert.SerializeObject(deviceValuesUpdated);
        }
    }
}
