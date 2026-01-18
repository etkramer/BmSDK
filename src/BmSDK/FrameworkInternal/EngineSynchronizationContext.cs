using System.Collections.Concurrent;

namespace BmSDK.Framework;

public sealed class EngineSynchronizationContext : SynchronizationContext
{
    private readonly ConcurrentQueue<(SendOrPostCallback callback, object? state)> _queue = new();

    public override void Post(SendOrPostCallback d, object? state)
        => _queue.Enqueue((d, state));

    internal void ExecutePending()
    {
        while (_queue.TryDequeue(out var work))
        {
            work.callback(work.state);
        }
    }
}
