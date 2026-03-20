#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_MeetingPoint<br/>
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_MeetingPoint : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_MeetingPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_MeetingPoint() { }

    /// <summary>
    /// Constructs a new RAnimNotify_MeetingPoint
    /// </summary>
    public RAnimNotify_MeetingPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_MeetingPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_MeetingPoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: Type
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_MeetingPoint.EMeetingPointType Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_MeetingPoint.EMeetingPointType>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: Rotation
    /// </summary>
    public unsafe bool Rotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: Translation
    /// </summary>
    public unsafe bool Translation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }

    /// <summary>
    /// StructProperty: RotationComponents
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_MeetingPoint.FMeetingPointRotationComponents RotationComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_MeetingPoint.FMeetingPointRotationComponents>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: TranslationComponents
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_MeetingPoint.FMeetingPointTranslationComponents TranslationComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_MeetingPoint.FMeetingPointTranslationComponents>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// Enum: EMeetingPointType
    /// </summary>
    public enum EMeetingPointType
    {
        MPT_End = 0,
        MPT_Begin = 1,
        MPT_MAX = 2,
    }
}
