#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSimpleRopeComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RSimpleRopeComponent : BmSDK.BmGame.RRopeComponentBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSimpleRopeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSimpleRopeComponent() { }

    /// <summary>
    /// Constructs a new RSimpleRopeComponent
    /// </summary>
    public RSimpleRopeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSimpleRopeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSimpleRopeComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: RopeSphereWeight
    /// </summary>
    public unsafe float RopeSphereWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: RopeSectionLength
    /// </summary>
    public unsafe float RopeSectionLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bEnableRopeSpooling
    /// </summary>
    public unsafe bool bEnableRopeSpooling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 724); }
    }

    /// <summary>
    /// FloatProperty: SpoolEffectStength
    /// </summary>
    public unsafe float SpoolEffectStength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// IntProperty: PreviousSpoolArraySize
    /// </summary>
    public unsafe int PreviousSpoolArraySize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: RopeSplinePath
    /// </summary>
    public unsafe BmSDK.Engine.SplineActor RopeSplinePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SplineActor>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }
}
