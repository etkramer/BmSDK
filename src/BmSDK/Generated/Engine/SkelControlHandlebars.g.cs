#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControlHandlebars<br/>
/// (flags = 0)
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// ByteProperty: HandlebarRotateAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis HandlebarRotateAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 297); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 297); }
    }

    /// <summary>
    /// NameProperty: WheelBoneName
    /// </summary>
    public unsafe BmSDK.FName WheelBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: bInvertRotation
    /// </summary>
    public unsafe bool bInvertRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: SteerWheelBoneIndex
    /// </summary>
    public unsafe int SteerWheelBoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }
}
