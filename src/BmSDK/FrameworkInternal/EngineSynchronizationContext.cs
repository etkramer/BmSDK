using System.Collections.Concurrent;
using System.Runtime.ExceptionServices;

namespace BmSDK.Framework;

/// <summary>
/// An implementation of SynchronizationContext that marshals work to the engine's main thread.
/// This is done by queuing requests. Then, callbacks are executed on <code>FEngineLoop::Tick()</code>
/// </summary>
public sealed class EngineSynchronizationContext : SynchronizationContext
{
    /// <summary>
    /// The singleton instance used to call
    /// <see cref="Post(SendOrPostCallback, object?)"/> and <see cref="Send(SendOrPostCallback, object?)"/>
    /// from other threads as the current SynchronizationContext is thread-dependent.
    /// </summary>
    public static readonly EngineSynchronizationContext Instance = new();
    internal static void InitOnThread() => SetSynchronizationContext(Instance);

    /// <summary>
    /// The ID of the thread that instantiated the singleton.
    /// This is always the <see cref="Loader.DllMain"/> which runs on the game thread.
    /// </summary>
    public readonly int MainThreadId = Environment.CurrentManagedThreadId;
    private readonly ConcurrentQueue<(SendOrPostCallback callback, object? state)> _queue = new();

    private EngineSynchronizationContext() { }

    public override void Post(SendOrPostCallback d, object? state)
    {
        // If already on main thread, execute directly
        if (Environment.CurrentManagedThreadId == MainThreadId)
        {
            d(state);
            return;
        }

        _queue.Enqueue((d, state));
    }

    /// <summary>
    /// Executes all the scheduled callbacks on the main thread.
    /// Called from <see cref="Loader.EngineTickDetour(nint)"/>.
    /// </summary>
    internal void ExecutePending()
    {
        while (_queue.TryDequeue(out var work))
        {
            work.callback(work.state);
        }
    }

    public override void Send(SendOrPostCallback d, object? state)
    {
        // If already on main thread, execute directly
        if (Environment.CurrentManagedThreadId == MainThreadId)
        {
            d(state);
            return;
        }

        using var done = new ManualResetEventSlim();
        Exception? capturedException = null;

        // Passthrough callback to main thread
        Post(_ =>
        {
            try
            {
                d(state);
            }
            catch (Exception exception)
            {
                capturedException = exception;
            }
            finally
            {
                done.Set();
            }
        },
        state: null);

        // Block the calling thread until main thread finished
        done.Wait();

        // Re-throw exceptions on calling thread
        if (capturedException != null)
        {
            ExceptionDispatchInfo
                .Capture(capturedException)
                .Throw();
        }
    }
}
