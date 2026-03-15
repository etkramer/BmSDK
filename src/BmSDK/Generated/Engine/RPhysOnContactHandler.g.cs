#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RPhysOnContactHandler<br/>
/// (size = 52)
/// (flags = 134217874)
/// </summary>
public partial class RPhysOnContactHandler : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RPhysOnContactHandler", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPhysOnContactHandler() { }

    /// <summary>
    /// Constructs a new RPhysOnContactHandler
    /// </summary>
    public RPhysOnContactHandler(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPhysOnContactHandler Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPhysOnContactHandler(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: OnContact
    /// </summary>
    public unsafe void OnContact(BmSDK.Engine.RB_BodyInstance BodyInst0, BmSDK.Engine.RB_BodyInstance BodyInst1, System.Numerics.Vector3 SumNormalForce, System.Numerics.Vector3 SumFrictionForce)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RPhysOnContactHandler.OnContact", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BodyInst0, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BodyInst1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SumNormalForce, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SumFrictionForce, paramsPtr + 20);
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

    /// <summary>
    /// ObjectProperty: OwnerObject
    /// </summary>
    public unsafe BmSDK.GameObject OwnerObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: bEnableCapeSpam
    /// </summary>
    public unsafe bool bEnableCapeSpam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }
}
