#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerJoker_Ch5Hallucination<br/>
/// (size = 10072)
/// (flags = 10485814)
/// </summary>
public partial class RPawnPlayerJoker_Ch5Hallucination : BmSDK.BmGame.RPawnPlayerJokerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerJoker_Ch5Hallucination", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerJoker_Ch5Hallucination() { }

    /// <summary>
    /// Constructs a new RPawnPlayerJoker_Ch5Hallucination
    /// </summary>
    public RPawnPlayerJoker_Ch5Hallucination(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerJoker_Ch5Hallucination Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerJoker_Ch5Hallucination(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker_Ch5Hallucination>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker_Ch5Hallucination>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker_Ch5Hallucination>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker_Ch5Hallucination>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker_Ch5Hallucination>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker_Ch5Hallucination>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker_Ch5Hallucination>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: VisibilitySwitchTimer
    /// </summary>
    public unsafe void VisibilitySwitchTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker_Ch5Hallucination.VisibilitySwitchTimer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker_Ch5Hallucination.Tick", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bCanSeePlayer
    /// </summary>
    public unsafe bool bCanSeePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10060) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10060); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10060); }
    }

    /// <summary>
    /// BoolProperty: bHiddenForHallucination
    /// </summary>
    public unsafe bool bHiddenForHallucination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10060) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10060); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10060); }
    }

    /// <summary>
    /// FloatProperty: VisibilityChance
    /// </summary>
    public unsafe float VisibilityChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10064); }
    }

    /// <summary>
    /// FloatProperty: MinTimeToMakeVisible
    /// </summary>
    public unsafe float MinTimeToMakeVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10068); }
    }
}
