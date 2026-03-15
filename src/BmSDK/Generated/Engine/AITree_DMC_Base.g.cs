#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AITree_DMC_Base<br/>
/// (size = 44)
/// (flags = 134217874)
/// </summary>
public partial class AITree_DMC_Base : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AITree_DMC_Base", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AITree_DMC_Base() { }

    /// <summary>
    /// Constructs a new AITree_DMC_Base
    /// </summary>
    public AITree_DMC_Base(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AITree_DMC_Base Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AITree_DMC_Base(nint ptr) : base(ptr) { }

}
