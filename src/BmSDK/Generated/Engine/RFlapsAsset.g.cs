#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RFlapsAsset<br/>
/// (flags = 0)
/// </summary>
public partial class RFlapsAsset : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RFlapsAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFlapsAsset() { }

    /// <summary>
    /// Constructs a new RFlapsAsset
    /// </summary>
    public RFlapsAsset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFlapsAsset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFlapsAsset(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: BodySetupIndexMap
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror BodySetupIndexMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: BodySetup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RFlaps_BodySetup> BodySetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RFlaps_BodySetup>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: ConstraintSetup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RFlaps_ConstraintSetup> ConstraintSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RFlaps_ConstraintSetup>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
}
