#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnVillainRiddlerMechSuitBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnVillainRiddlerMechSuitBase : BmSDK.BmGame.RPawnVillainThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainRiddlerMechSuitBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainRiddlerMechSuitBase() { }

    /// <summary>
    /// Constructs a new RPawnVillainRiddlerMechSuitBase
    /// </summary>
    public RPawnVillainRiddlerMechSuitBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainRiddlerMechSuitBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainRiddlerMechSuitBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainRiddlerMechSuitBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// IntProperty: NumPilotPound
    /// </summary>
    public unsafe int NumPilotPound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6696); }
    }

    /// <summary>
    /// FloatProperty: LastChargeCommandTIme
    /// </summary>
    public unsafe float LastChargeCommandTIme
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6700); }
    }

    /// <summary>
    /// FloatProperty: LastFarAttackTIme
    /// </summary>
    public unsafe float LastFarAttackTIme
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6704); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6708); }
    }

    /// <summary>
    /// ObjectProperty: TheMovieInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TheMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6716); }
    }
}
