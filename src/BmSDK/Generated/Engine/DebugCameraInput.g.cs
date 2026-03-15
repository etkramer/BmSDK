#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DebugCameraInput<br/>
/// (size = 356)
/// (flags = 30)
/// </summary>
public partial class DebugCameraInput : BmSDK.Engine.PlayerInput, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DebugCameraInput", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DebugCameraInput() { }

    /// <summary>
    /// Constructs a new DebugCameraInput
    /// </summary>
    public DebugCameraInput(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DebugCameraInput Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DebugCameraInput(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: InputKey
    /// </summary>
    public unsafe bool InputKey(int ControllerId, BmSDK.FName Key, BmSDK.GameObject.EInputEvent Event, float AmountDepressed = default, bool bGamepad = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.DebugCameraInput.InputKey", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmountDepressed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGamepad, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }
}
