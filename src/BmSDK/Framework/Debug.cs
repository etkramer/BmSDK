using System.Diagnostics;

namespace BmSDK.Framework;

public static class Debug
{
    private static readonly Stack<string> s_senderStack = new();

    internal static void PushSender(string sender)
    {
        s_senderStack.Push(sender);
    }

    internal static void PopSender()
    {
        s_senderStack.Pop();
    }

    private static void LogInternal(string msg)
    {
        // Get sender
        s_senderStack.TryPeek(out var sender);
        sender ??= "UNKNOWN";

        Trace.WriteLine($"{sender}: {msg}");
    }

    public static void Log(object? msg)
    {
        LogInternal(msg?.ToString() ?? "null");
    }

    public static void LogWarning(object msg)
    {
        // TODO: Colorize
        Log(msg);
    }

    public static void LogError(object msg)
    {
        // TODO: Colorize
        Log(msg);
    }
}
