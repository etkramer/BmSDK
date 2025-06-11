namespace BmSDK;

public interface IStaticObject
{
    public static abstract Class StaticClass();
}

public partial class GameObject
{
    public IntPtr Ptr { get; internal set; } = IntPtr.Zero;

    [Flags]
    public enum EObjectFlags : ulong
    {
        RF_RootSet = 0x400,
    }
}
