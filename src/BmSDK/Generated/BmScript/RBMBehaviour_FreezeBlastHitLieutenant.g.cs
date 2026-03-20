#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_FreezeBlastHitLieutenant<br/>
/// (size = 632)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_FreezeBlastHitLieutenant : BmSDK.BmGame.RBMBehaviour_FreezeBlastHit, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_FreezeBlastHitLieutenant", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_FreezeBlastHitLieutenant() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_FreezeBlastHitLieutenant
    /// </summary>
    public RBMBehaviour_FreezeBlastHitLieutenant(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_FreezeBlastHitLieutenant Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_FreezeBlastHitLieutenant(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: LieutenantHit
    /// </summary>
    public unsafe void LieutenantHit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_FreezeBlastHitLieutenant.LieutenantHit", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BreakTorso
    /// </summary>
    public unsafe void BreakTorso()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_FreezeBlastHitLieutenant.BreakTorso", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BreakRight
    /// </summary>
    public unsafe void BreakRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_FreezeBlastHitLieutenant.BreakRight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BreakLeft
    /// </summary>
    public unsafe void BreakLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_FreezeBlastHitLieutenant.BreakLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe void Initialise(BmSDK.BmGame.RPawnPlayer Instigator, System.Numerics.Vector3 HitNorm, bool bInstantFreeze = default, BmSDK.BmGame.RFreezeSprayProjectile Proj = default, bool bShouldAlwaysRagdoll = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_FreezeBlastHitLieutenant.Initialise", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Instigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNorm, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantFreeze, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proj, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldAlwaysRagdoll, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
