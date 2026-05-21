#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_Event<br/>
/// (size = 164)
/// (flags = 134221970)
/// </summary>
public partial class AkActionGlobal_Event : BmSDK.Engine.AkActionGlobal, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_Event", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as AkActionGlobal_Event.
    /// </summary>
    public static AkActionGlobal_Event DefaultObject => (AkActionGlobal_Event)StaticClass().DefaultObject;

    internal AkActionGlobal_Event() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_Event
    /// </summary>
    public AkActionGlobal_Event(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_Event Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_Event(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkActionGlobal_Event>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkActionGlobal_Event>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkActionGlobal_Event>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkActionGlobal_Event>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkActionGlobal_Event>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkActionGlobal_Event>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkActionGlobal_Event>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkActionGlobal_Event>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: GlobalEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GlobalEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ByteProperty: GlobalSource
    /// </summary>
    public unsafe BmSDK.Engine.AkActionGlobal_Event.EGlobalEventType GlobalSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkActionGlobal_Event.EGlobalEventType>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bUseSharedSource
    /// </summary>
    public unsafe bool bUseSharedSource
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bPlaying
    /// </summary>
    public unsafe bool bPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// Enum: EGlobalEventType
    /// </summary>
    public enum EGlobalEventType : byte
    {
        AK_GLOBAL_EVENT_SFX = 0,
        AK_GLOBAL_EVENT_MUSIC = 1,
        AK_GLOBAL_EVENT_DIALOGUE = 2,
        AK_GLOBAL_EVENT_AMBIENCE = 3,
        AK_GLOBAL_EVENT_WEATHER = 4,
        AK_GLOBAL_EVENT_UI = 5,
        AK_GLOBAL_EVENT_HUD = 6,
        AK_GLOBAL_EVENT_KISMET = 7,
        AK_GLOBAL_EVENT_MOVIE = 8,
        AK_GLOBAL_EVENT_MATINEE = 9,
        AK_GLOBAL_EVENT_PHYSICS = 10,
        AK_GLOBAL_EVENT_ENVIRONMENT = 11,
        AK_GLOBAL_EVENT_PAD = 12,
        AK_GLOBAL_EVENT_FLASH = 13,
        AK_GLOBAL_EVENT_MAX = 14,
    }
}
