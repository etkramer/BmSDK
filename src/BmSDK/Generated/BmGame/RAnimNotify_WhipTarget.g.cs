#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_WhipTarget<br/>
/// (size = 104)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_WhipTarget : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_WhipTarget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_WhipTarget() { }

    /// <summary>
    /// Constructs a new RAnimNotify_WhipTarget
    /// </summary>
    public RAnimNotify_WhipTarget(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_WhipTarget Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_WhipTarget(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: TargetingType
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_WhipTarget.WhipTargetingType TargetingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_WhipTarget.WhipTargetingType>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// NameProperty: TargetingStartBoneName
    /// </summary>
    public unsafe BmSDK.FName TargetingStartBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// NameProperty: TargetingEndBoneName
    /// </summary>
    public unsafe BmSDK.FName TargetingEndBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// Enum: WhipTargetingType
    /// </summary>
    public enum WhipTargetingType
    {
        WhipTargeting_Instantaneous = 0,
        WhipTargeting_Continuous = 1,
        WhipTargeting_MAX = 2,
    }
}
