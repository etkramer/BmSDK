#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_IK_Offset_Predict<br/>
/// (size = 84)
/// (flags = 33566738)
/// </summary>
public partial class RAnimNotify_IK_Offset_Predict : BmSDK.BmGame.RAnimNotify_IK, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_IK_Offset_Predict", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_IK_Offset_Predict() { }

    /// <summary>
    /// Constructs a new RAnimNotify_IK_Offset_Predict
    /// </summary>
    public RAnimNotify_IK_Offset_Predict(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_IK_Offset_Predict Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_IK_Offset_Predict(nint ptr) : base(ptr) { }

}
