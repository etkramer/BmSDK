using BmSDK.Framework;

namespace BmSDK;

[StructLayout(LayoutKind.Explicit)]
unsafe record struct FFrame
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

    public readonly Function GetFunction()
    {
        var nodePtr = Node;
        return MarshalUtil.ToManaged<Function>(&nodePtr);
    }

    public readonly IEnumerable<object?> ParamsToManaged(Type[] managedTypes)
    {
        var nodePtr = Node;
        var localsPtr = Locals;
        var funcObj = GetFunction();

        return funcObj
            .EnumerateParams()
            .Select(
                (prop, i) =>
                {
                    var typeManaged = managedTypes[i];
                    var valueManaged = MarshalUtil.ToManaged(localsPtr + prop.Offset, typeManaged);

                    return valueManaged;
                }
            );
    }
}
