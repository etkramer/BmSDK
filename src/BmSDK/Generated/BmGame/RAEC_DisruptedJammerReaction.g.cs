#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_DisruptedJammerReaction<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAEC_DisruptedJammerReaction : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_DisruptedJammerReaction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAEC_DisruptedJammerReaction() { }

    /// <summary>
    /// Constructs a new RAEC_DisruptedJammerReaction
    /// </summary>
    public RAEC_DisruptedJammerReaction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAEC_DisruptedJammerReaction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_DisruptedJammerReaction(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_DisruptedJammerReaction>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_DisruptedJammerReaction>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_DisruptedJammerReaction>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_DisruptedJammerReaction>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_DisruptedJammerReaction>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_DisruptedJammerReaction>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_DisruptedJammerReaction>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: StartTime
    /// </summary>
    public unsafe float StartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: DisruptedJammerThug
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DisruptedJammerThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: JammerThugAEC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JammerThugAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// BoolProperty: bPlayedStartLine
    /// </summary>
    public unsafe bool bPlayedStartLine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: bDoingExit
    /// </summary>
    public unsafe bool bDoingExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }
}
