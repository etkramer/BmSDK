#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleKillBox<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleKillBox : BmSDK.Engine.ParticleModuleKillBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleKillBox", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleKillBox() { }

    /// <summary>
    /// Constructs a new ParticleModuleKillBox
    /// </summary>
    public ParticleModuleKillBox(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleKillBox Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleKillBox(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: LowerLeftCorner
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleKillBox.UpperRightCorner LowerLeftCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleKillBox.UpperRightCorner>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: UpperRightCorner
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UpperRightCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bAbsolute
    /// </summary>
    public unsafe bool bAbsolute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bKillInside
    /// </summary>
    public unsafe bool bKillInside
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bAxisAlignedAndFixedSize
    /// </summary>
    public unsafe bool bAxisAlignedAndFixedSize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }
}
