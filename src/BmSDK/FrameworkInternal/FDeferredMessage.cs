namespace BmSDK.Framework;

[StructLayout(LayoutKind.Sequential)]
public struct FDeferredMessage
{
    public IntPtr Viewport;
    public uint Message;
    public nuint WParam;
    public nint LParam;
    // (...)
}
