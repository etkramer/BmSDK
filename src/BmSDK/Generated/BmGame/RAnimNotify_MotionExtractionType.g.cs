#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_MotionExtractionType<br/>
/// (size = 45)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_MotionExtractionType : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_MotionExtractionType", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_MotionExtractionType() { }

    /// <summary>
    /// Constructs a new RAnimNotify_MotionExtractionType
    /// </summary>
    public RAnimNotify_MotionExtractionType(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_MotionExtractionType Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_MotionExtractionType(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: Type
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_MotionExtractionType.EMotionExtractionType Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_MotionExtractionType.EMotionExtractionType>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// Enum: EMotionExtractionType
    /// </summary>
    public enum EMotionExtractionType
    {
        MET_CentreOfMass = 0,
        MET_Pelvis = 1,
        MET_MAX = 2,
    }
}
