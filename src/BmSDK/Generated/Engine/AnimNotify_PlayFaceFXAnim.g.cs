#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNotify_PlayFaceFxAnim<br/>
/// (flags = 0)
/// </summary>
public partial class AnimNotify_PlayFaceFxAnim : BmSDK.Engine.AnimNotify_Scripted, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNotify_PlayFaceFxAnim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNotify_PlayFaceFxAnim() { }

    /// <summary>
    /// Constructs a new AnimNotify_PlayFaceFxAnim
    /// </summary>
    public AnimNotify_PlayFaceFxAnim(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNotify_PlayFaceFxAnim Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNotify_PlayFaceFxAnim(nint ptr) : base(ptr) { }

}
