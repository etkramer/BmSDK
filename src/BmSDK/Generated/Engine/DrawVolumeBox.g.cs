#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DrawVolumeBox<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DrawVolumeBox : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DrawVolumeBox", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DrawVolumeBox() { }

    /// <summary>
    /// Constructs a new DrawVolumeBox
    /// </summary>
    public DrawVolumeBox(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DrawVolumeBox Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DrawVolumeBox(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: AllowTranslucentSelection
    /// </summary>
    public unsafe bool AllowTranslucentSelection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 540); }
    }

    /// <summary>
    /// StructProperty: BackColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BackColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ByteProperty: VolumeType
    /// </summary>
    public unsafe byte VolumeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// Enum: EDrawVolumeBoxType
    /// </summary>
    public enum EDrawVolumeBoxType
    {
        DVBT_Decal = 0,
        DVBT_Reflection = 1,
        DVBT_AILedgeDangerVol = 2,
        DVBT_MapHighlight = 3,
        DVBT_RainBlocker = 4,
        DVBT_MAX = 5,
    }
}
