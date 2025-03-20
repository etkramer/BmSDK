namespace SDKGenerator.Utils;

public static class DebugUtils
{
    static TextWriter? s_storedOutWriter;

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
}
