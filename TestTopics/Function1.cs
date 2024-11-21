using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TestTopics
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([ServiceBusTrigger("ventas", "ropa", Connection = "azstring")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
