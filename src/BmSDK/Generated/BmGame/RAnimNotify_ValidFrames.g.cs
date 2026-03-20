#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_ValidFrames<br/>
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_ValidFrames : BmSDK.BmGame.RAnimNotify_BeginEnd, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_ValidFrames", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_ValidFrames() { }

    /// <summary>
    /// Constructs a new RAnimNotify_ValidFrames
    /// </summary>
    public RAnimNotify_ValidFrames(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_ValidFrames Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_ValidFrames(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: Type
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_BeginEnd.EBeginEndType Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_BeginEnd.EBeginEndType>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// Enum: EBeginEndType
    /// </summary>
    public enum EBeginEndType
    {
        BET_Begin = 0,
        BET_End = 1,
        BET_MAX = 2,
    }
}
