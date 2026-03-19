#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RFreezeBlastEffectComponent<br/>
/// (size = 0)
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
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HitBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 188); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bPlayedRightLegIceExplodeVFX
    /// </summary>
    public unsafe bool bPlayedRightLegIceExplodeVFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bPlayedTorsoIceExplodeVFX
    /// </summary>
    public unsafe bool bPlayedTorsoIceExplodeVFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }
}
