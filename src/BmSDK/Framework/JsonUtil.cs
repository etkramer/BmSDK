using System.Text.Json;

namespace BmSDK.Framework;

public static class JsonUtil
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
}
