#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeBlendByPosture<br/>
/// (size = 340)
/// (flags = 0)
/// </summary>
public partial class AnimNodeBlendByPosture : BmSDK.Engine.AnimNodeBlendList, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodeBlendByPosture", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNodeBlendByPosture() { }

    /// <summary>
    /// Constructs a new AnimNodeBlendByPosture
    /// </summary>
    public AnimNodeBlendByPosture(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodeBlendByPosture Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodeBlendByPosture(nint ptr) : base(ptr) { }

}
