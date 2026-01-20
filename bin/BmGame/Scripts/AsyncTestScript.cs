[Script]
public class AsyncTestScript : Script
{
    private static readonly Timer _delayTimer = new(DelayTimerCallback);
    private const int DelayMillis = 1000;

    /// <summary>
    /// This method is called by _delayTimer and run on a separate thread.
    /// However, if we want to interact with the game safely,
    /// we must be on the main thread.  
    /// Therefore, we must use <see cref="EngineSynchronizationContext">.
    /// </summary>
    private static void DelayTimerCallback(object? state)
    {
        PrintCurrentThread();   // IsMainThread: false
        // SynchronizationContext.Send() blocks the calling thread.
        // SynchronizationContext.Post() would just schedule the lambda
        //      to be executed on the next FEngineLoop::Tick().
        EngineSynchronizationContext.Instance.Send(_ =>
        {
            // NOTE: Now we may manipulate the game
            PrintCurrentThread();   // IsMainThread: true
            var rpc = Game.GetPlayerController();
            if (!rpc.IsValid()) return;
            // Toggle detective vision
            rpc.bInvestigateMode ^= true;
        },
        state: null);
        PrintCurrentThread();   // IsMainThread: false
    }

    private static void PrintCurrentThread()
        => Debug.Log("IsMainThread: " + IsMainThread());

    private static bool IsMainThread()
        => Environment.CurrentManagedThreadId
        == EngineSynchronizationContext.Instance.MainThreadId;

    public override void OnKeyDown(Keys key)
    {
        if (key != Keys.M) return;
        _delayTimer.Change(DelayMillis, 0);
    }
}