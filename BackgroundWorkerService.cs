
using library_backend.Manager;
using System.Threading;

public class BackgroundWorkerService : BackgroundService
{
    private readonly IServiceScopeFactory _factory;

    public BackgroundWorkerService(IServiceScopeFactory factory)
    {
        _factory = factory;
    }

    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await using AsyncServiceScope asyncScope = _factory.CreateAsyncScope();
            var manager = asyncScope.ServiceProvider.GetRequiredService<IBookManager>();
            await manager.FindLateBooks();
            var waitTime = new TimeSpan(23, 59, 59) - DateTime.Now.TimeOfDay;
            await Task.Delay(waitTime, stoppingToken); // Run every 12am
        }
    }
}
