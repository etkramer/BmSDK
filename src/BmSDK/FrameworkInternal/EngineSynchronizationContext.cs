using System.Collections.Concurrent;

namespace BmSDK.Framework;

public sealed class EngineSynchronizationContext : SynchronizationContext
{
    private static readonly EngineSynchronizationContext s_instance = new();
    internal static EngineSynchronizationContext Instance => s_instance;

    internal static void Init() => SetSynchronizationContext(s_instance);

    private readonly ConcurrentQueue<(SendOrPostCallback callback, object? state)> _queue = new();

    private EngineSynchronizationContext() { }

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
