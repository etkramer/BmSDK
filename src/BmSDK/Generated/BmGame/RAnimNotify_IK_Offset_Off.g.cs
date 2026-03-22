#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_IK_Offset_Off<br/>
/// (size = 52)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_IK_Offset_Off : BmSDK.BmGame.RAnimNotify_IK, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_IK_Offset_Off", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_IK_Offset_Off() { }

    /// <summary>
    /// Constructs a new RAnimNotify_IK_Offset_Off
    /// </summary>
    public RAnimNotify_IK_Offset_Off(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_IK_Offset_Off Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_IK_Offset_Off(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: BlendOutDuration
    /// </summary>
    public unsafe float BlendOutDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }
}
