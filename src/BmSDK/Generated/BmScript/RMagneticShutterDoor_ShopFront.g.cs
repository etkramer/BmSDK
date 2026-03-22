#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RMagneticShutterDoor_ShopFront<br/>
/// (size = 856)
/// (flags = 8389138)
/// </summary>
public partial class RMagneticShutterDoor_ShopFront : BmSDK.BmScript.RMagneticDoor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RMagneticShutterDoor_ShopFront", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMagneticShutterDoor_ShopFront() { }

    /// <summary>
    /// Constructs a new RMagneticShutterDoor_ShopFront
    /// </summary>
    public RMagneticShutterDoor_ShopFront(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMagneticShutterDoor_ShopFront Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMagneticShutterDoor_ShopFront(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticShutterDoor_ShopFront>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticShutterDoor_ShopFront>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticShutterDoor_ShopFront>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticShutterDoor_ShopFront>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticShutterDoor_ShopFront>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticShutterDoor_ShopFront>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticShutterDoor_ShopFront>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

}
