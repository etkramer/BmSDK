[Script]
public class AsyncTestScript : Script
{
    static readonly Timer s_delayTimer = new(DelayTimerCallback);
    const int DelayMillis = 1000;

    /// <summary>
    /// This method is called by s_delayTimer and run on a separate thread.
    /// However, if we want to interact with the game safely,
    /// we must be on the main thread.  
    /// Therefore, we must use <see cref="EngineSynchronizationContext">.
    /// </summary>
    static void DelayTimerCallback(object? state)
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
            if (!rpc.IsValid())
                return;
            // Toggle detective vision
            rpc.bInvestigateMode ^= true;
        },
        state: null);
        PrintCurrentThread();   // IsMainThread: false
    }

    static void PrintCurrentThread()
        => Debug.Log("IsMainThread: " + IsMainThread());

    static bool IsMainThread()
        => Environment.CurrentManagedThreadId
        == EngineSynchronizationContext.Instance.MainThreadId;

    public override void OnKeyDown(Keys key)
    {
        if (key != Keys.M)
            return;
        s_delayTimer.Change(DelayMillis, 0);
    }
}
