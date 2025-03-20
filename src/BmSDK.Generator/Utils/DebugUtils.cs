namespace BmSDK.Generator.Utils;

public static class DebugUtils
{
    static TextWriter? s_storedOutWriter;
    static TextWriter? s_storedErrorWriter;

    public static void EnableStdout()
    {
        if (s_storedOutWriter is not null)
        {
            Console.SetOut(s_storedOutWriter);
        }
    }

    public static void DisableStdout()
    {
        s_storedOutWriter = Console.Out;
        Console.SetOut(TextWriter.Null);
    }

    public static void EnableStderr()
    {
        if (s_storedErrorWriter is not null)
        {
            Console.SetError(s_storedErrorWriter);
        }
    }

    public static void DisableStderr()
    {
        s_storedErrorWriter = Console.Error;
        Console.SetError(TextWriter.Null);
    }
}
