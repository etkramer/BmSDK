#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHidePointRope_RopeComponent<br/>
/// (size = 680)
/// (flags = 0)
/// </summary>
public partial class RHidePointRope_RopeComponent : BmSDK.BmGame.RRope2Component, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHidePointRope_RopeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHidePointRope_RopeComponent() { }

    /// <summary>
    /// Constructs a new RHidePointRope_RopeComponent
    /// </summary>
    public RHidePointRope_RopeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHidePointRope_RopeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHidePointRope_RopeComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: IsRopeLengthAutoCalculated
    /// </summary>
    public unsafe bool IsRopeLengthAutoCalculated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHidePointRope_RopeComponent.IsRopeLengthAutoCalculated", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }
}
