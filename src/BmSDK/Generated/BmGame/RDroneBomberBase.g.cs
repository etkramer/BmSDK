#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDroneBomberBase<br/>
/// (size = 556)
/// (flags = 142606994)
/// </summary>
public partial class RDroneBomberBase : BmSDK.Engine.InterpActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDroneBomberBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDroneBomberBase() { }

    /// <summary>
    /// Constructs a new RDroneBomberBase
    /// </summary>
    public RDroneBomberBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDroneBomberBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDroneBomberBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDroneBomberBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDroneBomberBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDroneBomberBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDroneBomberBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDroneBomberBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDroneBomberBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDroneBomberBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: DropBomb
    /// </summary>
    public unsafe virtual void DropBomb(bool LODBomb)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDroneBomberBase.DropBomb", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LODBomb, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bombingEnabled
    /// </summary>
    public unsafe bool bombingEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: dbgInPrimaryRange
    /// </summary>
    public unsafe bool dbgInPrimaryRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: dbgInSecondaryRange
    /// </summary>
    public unsafe bool dbgInSecondaryRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: dbgBlockedByVolume
    /// </summary>
    public unsafe bool dbgBlockedByVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bGotSequenceAction
    /// </summary>
    public unsafe bool bGotSequenceAction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: globalBombingEnabled
    /// </summary>
    public unsafe bool globalBombingEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: lastLaunchTime
    /// </summary>
    public unsafe float lastLaunchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// FloatProperty: timeToNextBomb
    /// </summary>
    public unsafe float timeToNextBomb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// FloatProperty: distToBMSq
    /// </summary>
    public unsafe float distToBMSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: timeBetweenBombDrops
    /// </summary>
    public unsafe float timeBetweenBombDrops
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: droneBombDropRangeSq
    /// </summary>
    public unsafe float droneBombDropRangeSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: droneBombDropSecondaryRangeSq
    /// </summary>
    public unsafe float droneBombDropSecondaryRangeSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

}
