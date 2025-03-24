namespace BmSDK.Generator.Utils;

public static class FlagUtils
{
    public static T DropUnknownBits<T>(T flags)
        where T : Enum
    {
        var flagValue = Convert.ToUInt64(flags);
        var definedFlags = 0ul;

        foreach (var value in Enum.GetValues(flags.GetType()))
        {
            var enumValue = Convert.ToUInt64(value);
            if ((flagValue & enumValue) == enumValue)
            {
                definedFlags |= enumValue;
            }
        }

        return (T)Enum.ToObject(typeof(T), definedFlags);
    }
}
