#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AICommandNodeRoot<br/>
/// (size = 92)
/// (flags = 134217874)
/// </summary>
public partial class AICommandNodeRoot : BmSDK.Engine.AICommandNodeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AICommandNodeRoot", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AICommandNodeRoot() { }

    /// <summary>
    /// Constructs a new AICommandNodeRoot
    /// </summary>
    public AICommandNodeRoot(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AICommandNodeRoot Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AICommandNodeRoot(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: RootName
    /// </summary>
    public unsafe BmSDK.FName RootName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
