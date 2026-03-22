#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControlHandlebars<br/>
/// (size = 240)
/// (flags = 142606482)
/// </summary>
public partial class SkelControlHandlebars : BmSDK.Engine.SkelControlSingleBone, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControlHandlebars", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkelControlHandlebars() { }

    /// <summary>
    /// Constructs a new SkelControlHandlebars
    /// </summary>
    public SkelControlHandlebars(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControlHandlebars Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControlHandlebars(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: WheelRollAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis WheelRollAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ByteProperty: HandlebarRotateAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis HandlebarRotateAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 221); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 221); }
    }

    /// <summary>
    /// NameProperty: WheelBoneName
    /// </summary>
    public unsafe BmSDK.FName WheelBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bInvertRotation
    /// </summary>
    public unsafe bool bInvertRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 232); }
    }

    /// <summary>
    /// IntProperty: SteerWheelBoneIndex
    /// </summary>
    public unsafe int SteerWheelBoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
}
