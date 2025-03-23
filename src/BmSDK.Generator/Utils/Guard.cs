using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace BmSDK.Generator.Utils;

/// <summary>
/// Provides utility methods for ensuring conditions are met.
/// </summary>
public static class Guard
{
    [DebuggerHidden]
    public static bool Require(bool value, string? message = null)
    {
        if (!value)
        {
            throw new ArgumentException(message ?? "Got unexpected false");
        }

        return value;
    }

    [DebuggerHidden]
    public static T NotNull<T>([NotNull] T? obj, string? message = null)
        where T : class
    {
        if (obj is null)
        {
            throw new ArgumentException(message ?? "Got unexpected null");
        }

        return obj;
    }

    [DebuggerHidden]
    public static string NotNullOrWhitespace([NotNull] string? obj, string? message = null)
    {
        if (obj is null)
        {
            throw new ArgumentException(message ?? "Got unexpected null");
        }

        if (string.IsNullOrWhiteSpace(obj))
        {
            throw new ArgumentException(message ?? "Got unexpected whitespace");
        }

        return obj;
    }
}
