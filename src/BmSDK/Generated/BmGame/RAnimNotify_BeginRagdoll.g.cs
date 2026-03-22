#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_BeginRagdoll<br/>
/// (size = 76)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_BeginRagdoll : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_BeginRagdoll", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_BeginRagdoll() { }

    /// <summary>
    /// Constructs a new RAnimNotify_BeginRagdoll
    /// </summary>
    public RAnimNotify_BeginRagdoll(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_BeginRagdoll Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_BeginRagdoll(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: BlendInDuration
    /// </summary>
    public unsafe float BlendInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// FloatProperty: BlendOutDuration
    /// </summary>
    public unsafe float BlendOutDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// StructProperty: FixedParts
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.FRagdollParts FixedParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FRagdollParts>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// StructProperty: UnfixedParts
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.FRagdollParts UnfixedParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FRagdollParts>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: MotorAll
    /// </summary>
    public unsafe bool MotorAll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// StructProperty: MotorParts
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.FRagdollParts MotorParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FRagdollParts>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: MotorSpringScale
    /// </summary>
    public unsafe float MotorSpringScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// FloatProperty: MotorDampingScale
    /// </summary>
    public unsafe float MotorDampingScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }
}
