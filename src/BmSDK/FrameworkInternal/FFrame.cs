using BmSDK.Framework;

namespace BmSDK;

[StructLayout(LayoutKind.Explicit)]
internal unsafe record struct FFrame
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

    public readonly IEnumerable<object?> ParamsToManaged()
    {
        var nodePtr = Node;
        var localsPtr = Locals;
        var funcObj = MarshalUtil.ToManaged<UFunction>(&nodePtr);

        return funcObj
            .EnumerateParams()
            .Select(prop =>
            {
                var valuePtr = localsPtr + prop.Offset;
                // var valueManaged = MarshalUtil.ToManaged<Engine.UCanvas>(valuePtr);

                var valueManaged = MarshalUtil.ToManaged2(valuePtr, typeof(Engine.UCanvas));

                return valueManaged;
            });

        // foreach (var prop in funcObj.EnumerateParams())
        // {
        //     var valuePtr = Locals + prop.Offset;
        //     Debug.Log($"{prop.Name} is at {prop.Offset} (0x{valuePtr:X})");

        //     var valueManaged = MarshalUtil.ToManaged<Engine.UCanvas>(valuePtr);
        //     Debug.Log($"{prop.Name} is {valueManaged}");

        //     yield return valueManaged;
        // }
    }
}
