namespace BmSDK.Generator.Utils;

public static class WriterUtils
{
    public static void WriteLineIndented(this TextWriter writer, string value, int indent)
    {
        writer.WriteIndent(indent);
        writer.WriteLine(value);
    }

    public static void WriteIndent(this TextWriter writer, int indent)
    {
        for (int i = 0; i < indent; i++)
        {
            writer.Write("\t");
        }
    }
}
