#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPostFleePoint_Behaviour<br/>
/// (size = 460)
/// (flags = 8389138)
/// </summary>
public partial class RPostFleePoint_Behaviour : BmSDK.BmGame.RPostFleePoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPostFleePoint_Behaviour", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPostFleePoint_Behaviour() { }

    /// <summary>
    /// Constructs a new RPostFleePoint_Behaviour
    /// </summary>
    public RPostFleePoint_Behaviour(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPostFleePoint_Behaviour Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPostFleePoint_Behaviour(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPostFleePoint_Behaviour>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPostFleePoint_Behaviour>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPostFleePoint_Behaviour>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPostFleePoint_Behaviour>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPostFleePoint_Behaviour>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPostFleePoint_Behaviour>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPostFleePoint_Behaviour>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: UsedByPawn
    /// </summary>
    public unsafe override bool UsedByPawn(BmSDK.BmGame.RBMPawnAI NewUser, bool bInstantUse = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPostFleePoint_Behaviour.UsedByPawn", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewUser, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantUse, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: RecheckWanderBehaviour
    /// </summary>
    public unsafe virtual void RecheckWanderBehaviour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPostFleePoint_Behaviour.RecheckWanderBehaviour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPostFleePoint_Behaviour.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bAttachedToWanderBehaviour
    /// </summary>
    public unsafe bool bAttachedToWanderBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 456); }
    }
}
