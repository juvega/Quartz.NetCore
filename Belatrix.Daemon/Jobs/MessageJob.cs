using Microsoft.Extensions.Logging;
using Quartz;
using System.Threading.Tasks;

namespace Belatrix.Daemon.Jobs
{
    public class MessageJob : IJob
    {
        private readonly ILogger<MessageJob> _logger;
        public MessageJob(ILogger<MessageJob> logger)
        {
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("Message processed.");
            return Task.CompletedTask;
        }
    }
}
