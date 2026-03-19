#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNotify_CameraEffect<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AnimNotify_CameraEffect : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNotify_CameraEffect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNotify_CameraEffect() { }

    /// <summary>
    /// Constructs a new AnimNotify_CameraEffect
    /// </summary>
    public AnimNotify_CameraEffect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNotify_CameraEffect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNotify_CameraEffect(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: CameraLensEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraLensEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
