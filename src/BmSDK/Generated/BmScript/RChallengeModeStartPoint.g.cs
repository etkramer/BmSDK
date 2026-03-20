#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RChallengeModeStartPoint<br/>
/// (flags = 0)
/// </summary>
public partial class RChallengeModeStartPoint : BmSDK.BmGame.RChallengeModeStartPointBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RChallengeModeStartPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RChallengeModeStartPoint() { }

    /// <summary>
    /// Constructs a new RChallengeModeStartPoint
    /// </summary>
    public RChallengeModeStartPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RChallengeModeStartPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RChallengeModeStartPoint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPoint>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bCompletionFailed
    /// </summary>
    public unsafe bool bCompletionFailed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: bAbortChallenge
    /// </summary>
    public unsafe bool bAbortChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: bRestartChallenge
    /// </summary>
    public unsafe bool bRestartChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: DoFadeOnSuccess
    /// </summary>
    public unsafe bool DoFadeOnSuccess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: DoFadeOnFail
    /// </summary>
    public unsafe bool DoFadeOnFail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: DoFadeOnAbort
    /// </summary>
    public unsafe bool DoFadeOnAbort
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// BoolProperty: DoFadeOnRestart
    /// </summary>
    public unsafe bool DoFadeOnRestart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1512); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1512); }
    }

    /// <summary>
    /// StrProperty: sCompletionDebriefMessage
    /// </summary>
    public unsafe BmSDK.FString sCompletionDebriefMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// IntProperty: AfterFadeEventToTrigger
    /// </summary>
    public unsafe int AfterFadeEventToTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// FloatProperty: TimeSpentInWaitState
    /// </summary>
    public unsafe float TimeSpentInWaitState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// DelegateProperty: __CompleteRestartOrAbort__Delegate
    /// </summary>
    public unsafe System.IntPtr __CompleteRestartOrAbort__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }
}
