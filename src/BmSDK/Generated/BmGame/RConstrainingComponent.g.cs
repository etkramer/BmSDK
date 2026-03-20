#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RConstrainingComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RConstrainingComponent : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RConstrainingComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RConstrainingComponent() { }

    /// <summary>
    /// Constructs a new RConstrainingComponent
    /// </summary>
    public RConstrainingComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RConstrainingComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RConstrainingComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: ConstrainedComponent
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent ConstrainedComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: ConstraintSetups
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RB_ConstraintSetup> ConstraintSetups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RB_ConstraintSetup>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: Constraints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RB_ConstraintInstance> Constraints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RB_ConstraintInstance>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bConstraintsCleared
    /// </summary>
    public unsafe bool bConstraintsCleared
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }
}
