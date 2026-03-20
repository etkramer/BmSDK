#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_RootBoneTranslationOffset<br/>
/// (size = 88)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_RootBoneTranslationOffset : BmSDK.BmGame.RAnimNotify_BeginEnd, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_RootBoneTranslationOffset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_RootBoneTranslationOffset() { }

    /// <summary>
    /// Constructs a new RAnimNotify_RootBoneTranslationOffset
    /// </summary>
    public RAnimNotify_RootBoneTranslationOffset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_RootBoneTranslationOffset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_RootBoneTranslationOffset(nint ptr) : base(ptr) { }

}
