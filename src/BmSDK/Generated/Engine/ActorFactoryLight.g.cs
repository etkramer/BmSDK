#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryLight<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ActorFactoryLight : BmSDK.Engine.ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryLight", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryLight() { }

    /// <summary>
    /// Constructs a new ActorFactoryLight
    /// </summary>
    public ActorFactoryLight(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryLight Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryLight(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: LightComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
}
