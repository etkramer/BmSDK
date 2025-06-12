using System.Diagnostics;

namespace BmSDK.Framework;

public static class Debug
{
    private static readonly Stack<string> s_senderStack = new();
    private static readonly ConsoleColor s_defaultColor = Console.ForegroundColor;

    public static void Log(object? msg, bool skipSender = false)
    {
        LogInternal(msg?.ToString() ?? "null", skipSender);
    }

    public static void LogWarning(object msg, bool skipSender = false)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Log(msg, skipSender);
        Console.ForegroundColor = s_defaultColor;
    }

    public static void LogError(object msg, bool skipSender = false)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Log(msg, skipSender);
        Console.ForegroundColor = s_defaultColor;
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
