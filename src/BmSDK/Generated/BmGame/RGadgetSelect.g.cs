#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGadgetSelect<br/>
/// (flags = 0)
/// </summary>
public partial class RGadgetSelect : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGadgetSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGadgetSelect() { }

    /// <summary>
    /// Constructs a new RGadgetSelect
    /// </summary>
    public RGadgetSelect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGadgetSelect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGadgetSelect(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: OwnerPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController OwnerPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: DiagonalInDelay
    /// </summary>
    public unsafe float DiagonalInDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: DiagonalOutDelay
    /// </summary>
    public unsafe float DiagonalOutDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: SelectedColumn
    /// </summary>
    public unsafe byte SelectedColumn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ByteProperty: SelectedRow
    /// </summary>
    public unsafe byte SelectedRow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 101); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 101); }
    }

    /// <summary>
    /// ByteProperty: LastColumn
    /// </summary>
    public unsafe byte LastColumn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 102); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 102); }
    }

    /// <summary>
    /// ByteProperty: LastRow
    /// </summary>
    public unsafe byte LastRow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 103); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 103); }
    }

    /// <summary>
    /// ByteProperty: DoubleTapColumn
    /// </summary>
    public unsafe byte DoubleTapColumn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ByteProperty: DoubleTapRow
    /// </summary>
    public unsafe byte DoubleTapRow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 105); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 105); }
    }

    /// <summary>
    /// FloatProperty: LastSelectionTime
    /// </summary>
    public unsafe float LastSelectionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: DoubleTapTimer
    /// </summary>
    public unsafe float DoubleTapTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: WaitingToRecentre
    /// </summary>
    public unsafe bool WaitingToRecentre
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }
}
