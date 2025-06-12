using System.Diagnostics;

namespace BmSDK.Framework;

public static class Debug
{
    private static readonly Stack<string> s_senderStack = new();

    public static void Log(object? msg, bool skipSender = false)
    {
        LogInternal(msg?.ToString() ?? "null", skipSender);
    }

    public static void LogWarning(object msg, bool skipSender = false)
    {
        // TODO: Colorize
        Log(msg, skipSender);
    }

    public static void LogError(object msg, bool skipSender = false)
    {
        // TODO: Colorize
        Log(msg, skipSender);
    }

    private static void LogInternal(string msg, bool skipSender = false)
    {
        if (skipSender)
        {
            Trace.WriteLine(msg);
            return;
        }

        // Get sender
        s_senderStack.TryPeek(out var sender);
        sender ??= "UNKNOWN";

        Trace.WriteLine($"{sender}: {msg}");
    }

    internal static void PushSender(string sender)
    {
        s_senderStack.Push(sender);
    }

    internal static void PopSender()
    {
        s_senderStack.Pop();
    }
}
