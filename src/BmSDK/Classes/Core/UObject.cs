namespace BmSDK;

public interface IStaticObject
{
    public static abstract UClass StaticClass();
}

public partial class UObject
{
    public IntPtr Ptr { get; internal set; } = IntPtr.Zero;

    [Flags]
    public enum EObjectFlags : ulong
    {
        RF_RootSet = 0x400,
    }
}
