#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMap3DRoadComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RMap3DRoadComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMap3DRoadComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMap3DRoadComponent() { }

    /// <summary>
    /// Constructs a new RMap3DRoadComponent
    /// </summary>
    public RMap3DRoadComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMap3DRoadComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMap3DRoadComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: UpdateRouteMesh
    /// </summary>
    public unsafe void UpdateRouteMesh(int LinkStart, BmSDK.TArray<int> SatNavRoute)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RMap3DRoadComponent.UpdateRouteMesh", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SatNavRoute, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }
}
