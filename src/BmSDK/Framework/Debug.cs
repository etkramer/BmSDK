using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BmSDK.Framework;

public static class Debug
{
    static readonly Stack<string> s_senderStack = new();
    static readonly ConsoleColor s_defaultColor = Console.ForegroundColor;

    public static void Log(
        object? msg,
        bool skipSender = false,
        [CallerFilePath] string? callerFilePath = null
    )
    {
        var msgText = msg?.ToString() ?? "null";

        if (skipSender)
        {
            Trace.WriteLine(msg);
            return;
        }

        // Get sender, else fall back to the source file name.
        if (!s_senderStack.TryPeek(out var sender))
        {
            sender = callerFilePath is null ? "UNKNOWN" : Path.GetFileName(callerFilePath);
        }

        Trace.WriteLine($"{sender}: {msgText}");
    }

    public static void LogWarning(
        object msg,
        bool skipSender = false,
        [CallerFilePath] string? callerFilePath = null
    )
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Log(msg, skipSender, callerFilePath);
        Console.ForegroundColor = s_defaultColor;
    }

    public static void LogError(
        object msg,
        bool skipSender = false,
        [CallerFilePath] string? callerFilePath = null
    )
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Log(msg, skipSender, callerFilePath);
        Console.ForegroundColor = s_defaultColor;
    }

    internal static void PushSender(string sender)
    {
        s_senderStack.Push(sender);
    }

    internal static void PopSender()
    {
        s_senderStack.Pop();
    }

    internal static void RunWithSender(string sender, Action action)
    {
        s_senderStack.Push(sender);
        try
        {
            action();
        }
        finally
        {
            s_senderStack.Pop();
        }
    }
}
