#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpGroupAI<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpGroupAI : BmSDK.Engine.InterpGroup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpGroupAI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpGroupAI() { }

    /// <summary>
    /// Constructs a new InterpGroupAI
    /// </summary>
    public InterpGroupAI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpGroupAI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpGroupAI(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: PreviewPawnClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviewPawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// NameProperty: StageMarkGroup
    /// </summary>
    public unsafe BmSDK.FName StageMarkGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: SnapToRootBoneLocationWhenFinished
    /// </summary>
    public unsafe bool SnapToRootBoneLocationWhenFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bNoEncroachmentCheck
    /// </summary>
    public unsafe bool bNoEncroachmentCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bDisableWorldCollision
    /// </summary>
    public unsafe bool bDisableWorldCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreLegacyHeightAdjust
    /// </summary>
    public unsafe bool bIgnoreLegacyHeightAdjust
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bRecreatePreviewPawn
    /// </summary>
    public unsafe bool bRecreatePreviewPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bRefreshStageMarkGroup
    /// </summary>
    public unsafe bool bRefreshStageMarkGroup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }
}
