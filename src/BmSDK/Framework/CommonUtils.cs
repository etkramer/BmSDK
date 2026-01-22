using System.Collections;
using System.Text;
using System.Text.Json;

namespace BmSDK.Framework;

public static class CommonUtils
{
    static readonly JsonSerializerOptions s_opts = new()
    {
        WriteIndented = true,
        IncludeFields = false,
    };

    public static string ToJson<T>(this T obj)
    {
        return JsonSerializer.Serialize(obj, s_opts);
    }

    public static string Join(this IEnumerable items, string separator = ", ")
    {
        var sb = new StringBuilder();
        foreach (var item in items)
        {
            if (sb.Length > 0)
            {
                sb.Append(separator);
            }

            sb.Append(item?.ToString());
        }

        return sb.ToString();
    }

    public static string FormatPlural(int count, string singular, string? plural = null)
    {
        return count == 1 ? singular : (plural ?? $"{singular}s");
    }

    public static string FormatDuration(this TimeSpan span)
    {
        return span.TotalSeconds < 1
            ? $"{span.TotalMilliseconds:0}ms"
            : $"{span.TotalSeconds:0.##}s";
    }
}
