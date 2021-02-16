using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Services
{
    public interface ICronJobScopedService
    {
        Task DoWork(CancellationToken cancellationToken);
    }

    public class CronJobScopedService : ICronJobScopedService
    {
        private readonly ILogger<CronJobScopedService> _logger;

        public CronJobScopedService(ILogger<CronJobScopedService> logger)
        {
            _logger = logger;
        }

        public async Task DoWork(CancellationToken cancellationToken)
        {
            await Task.Delay(1000, cancellationToken);
        }
    }
}
