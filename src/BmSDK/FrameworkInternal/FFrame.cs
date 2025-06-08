#pragma warning disable CS0169
#pragma warning disable CS0649

using BmSDK.Framework;

namespace BmSDK;

[StructLayout(LayoutKind.Explicit)]
internal unsafe struct FFrame
{
    [FieldOffset(0x8)]
    public IntPtr Node;

    [FieldOffset(0xC)]
    public IntPtr Object;

    [FieldOffset(0x10)]
    public IntPtr Code;

    [FieldOffset(0x14)]
    public IntPtr Locals;

    [FieldOffset(0x18)]
    public IntPtr PreviousFrame;

    [FieldOffset(0x1C)]
    public IntPtr OutParms;

    public FFrame(
        UObject? InObject,
        UStruct InNode,
        int CodeOffset,
        ReadOnlySpan<byte> InLocals,
        FFrame* InPreviousFrame
    )
    {
        fixed (FFrame* thisPtr = &this)
        fixed (byte* localsPtr = InLocals)
        {
            GameFunctions.FrameCtor(
                (IntPtr)thisPtr,
                InObject?.Ptr ?? 0,
                InNode.Ptr,
                CodeOffset,
                (IntPtr)localsPtr,
                (IntPtr)InPreviousFrame
            );
        }
    }
}
