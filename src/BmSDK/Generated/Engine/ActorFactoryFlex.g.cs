#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryFlex<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ActorFactoryFlex : BmSDK.Engine.ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryFlex", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryFlex() { }

    /// <summary>
    /// Constructs a new ActorFactoryFlex
    /// </summary>
    public ActorFactoryFlex(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryFlex Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryFlex(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: StaticMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
}
