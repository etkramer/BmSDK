#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RFreezeBlastEffectComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RFreezeBlastEffectComponent : BmSDK.BmGame.RPawnEffectComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RFreezeBlastEffectComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFreezeBlastEffectComponent() { }

    /// <summary>
    /// Constructs a new RFreezeBlastEffectComponent
    /// </summary>
    public RFreezeBlastEffectComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFreezeBlastEffectComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFreezeBlastEffectComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: HitBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class HitBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// FloatProperty: CurrFreezeMaterialAmount
    /// </summary>
    public unsafe float CurrFreezeMaterialAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// FloatProperty: DestFreezeMaterialAmount
    /// </summary>
    public unsafe float DestFreezeMaterialAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: FreezeMaterialParameterSpeed
    /// </summary>
    public unsafe float FreezeMaterialParameterSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bPlayedLeftLegIceExplodeVFX
    /// </summary>
    public unsafe bool bPlayedLeftLegIceExplodeVFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bPlayedRightLegIceExplodeVFX
    /// </summary>
    public unsafe bool bPlayedRightLegIceExplodeVFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bPlayedTorsoIceExplodeVFX
    /// </summary>
    public unsafe bool bPlayedTorsoIceExplodeVFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }
}
