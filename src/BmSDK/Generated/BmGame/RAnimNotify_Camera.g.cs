#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_Camera<br/>
/// (size = 56)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_Camera : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_Camera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_Camera() { }

    /// <summary>
    /// Constructs a new RAnimNotify_Camera
    /// </summary>
    public RAnimNotify_Camera(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_Camera Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_Camera(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: NotifyType
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_Camera.CamNotifyType NotifyType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_Camera.CamNotifyType>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// FloatProperty: DesiredValue
    /// </summary>
    public unsafe float DesiredValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// FloatProperty: TimeToChange
    /// </summary>
    public unsafe float TimeToChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// Enum: CamNotifyType
    /// </summary>
    public enum CamNotifyType
    {
        CNT_None = 0,
        CNT_SetGameSpeed = 1,
        CNT_SetFOV = 2,
        CNT_SetMotionBlur = 3,
        CNT_MAX = 4,
    }
}
