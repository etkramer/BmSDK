#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SpeedTreeActorFactory<br/>
/// (flags = 0)
/// </summary>
public partial class SpeedTreeActorFactory : BmSDK.Engine.ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SpeedTreeActorFactory", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SpeedTreeActorFactory() { }

    /// <summary>
    /// Constructs a new SpeedTreeActorFactory
    /// </summary>
    public SpeedTreeActorFactory(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SpeedTreeActorFactory Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SpeedTreeActorFactory(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SpeedTree
    /// </summary>
    public unsafe BmSDK.Engine.SpeedTree SpeedTree
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpeedTree>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
}
