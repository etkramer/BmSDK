#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnFriendlyRobotBase<br/>
/// (size = 2788)
/// (flags = 10485814)
/// </summary>
public partial class RPawnFriendlyRobotBase : BmSDK.BmGame.RPawnFriendly, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnFriendlyRobotBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnFriendlyRobotBase() { }

    /// <summary>
    /// Constructs a new RPawnFriendlyRobotBase
    /// </summary>
    public RPawnFriendlyRobotBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnFriendlyRobotBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnFriendlyRobotBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnFriendlyRobotBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnFriendlyRobotBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnFriendlyRobotBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnFriendlyRobotBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnFriendlyRobotBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnFriendlyRobotBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnFriendlyRobotBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: InitDisabledRobot
    /// </summary>
    public unsafe virtual void InitDisabledRobot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnFriendlyRobotBase.InitDisabledRobot", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitRobot
    /// </summary>
    public unsafe virtual void InitRobot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnFriendlyRobotBase.InitRobot", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ScanningBegins
    /// </summary>
    public unsafe virtual void ScanningBegins()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnFriendlyRobotBase.ScanningBegins", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ScanComplete
    /// </summary>
    public unsafe virtual void ScanComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnFriendlyRobotBase.ScanComplete", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: MovieInfo
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 2748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2748); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenScanned
    /// </summary>
    public unsafe bool bHasBeenScanned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2752) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2752); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2752); }
    }

    /// <summary>
    /// FloatProperty: AmountOfDataInFirstRobot
    /// </summary>
    public unsafe float AmountOfDataInFirstRobot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2756); }
    }

    /// <summary>
    /// FloatProperty: AmountOfDataInThisRobot
    /// </summary>
    public unsafe float AmountOfDataInThisRobot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }

    /// <summary>
    /// FloatProperty: PrescanDurationFirstRobot
    /// </summary>
    public unsafe float PrescanDurationFirstRobot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// FloatProperty: PrescanDurationOtherRobot
    /// </summary>
    public unsafe float PrescanDurationOtherRobot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// FloatProperty: ScanAmountPerSecond
    /// </summary>
    public unsafe float ScanAmountPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2772); }
    }

    /// <summary>
    /// FloatProperty: ScanAmountPerSecondForSecondary
    /// </summary>
    public unsafe float ScanAmountPerSecondForSecondary
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2776); }
    }

    /// <summary>
    /// FloatProperty: AmountOfDataHeld
    /// </summary>
    public unsafe float AmountOfDataHeld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// FloatProperty: PrescanDuration
    /// </summary>
    public unsafe float PrescanDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }
}
