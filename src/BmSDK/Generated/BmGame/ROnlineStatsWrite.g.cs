#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: ROnlineStatsWrite<br/>
/// (size = 120)
/// (flags = 50)
/// </summary>
public partial class ROnlineStatsWrite : BmSDK.Engine.OnlineStatsWrite, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.ROnlineStatsWrite", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ROnlineStatsWrite() { }

    /// <summary>
    /// Constructs a new ROnlineStatsWrite
    /// </summary>
    public ROnlineStatsWrite(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ROnlineStatsWrite Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ROnlineStatsWrite(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ROnlineStatsWrite>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROnlineStatsWrite>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ROnlineStatsWrite>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROnlineStatsWrite>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROnlineStatsWrite>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ROnlineStatsWrite>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROnlineStatsWrite>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: CopyAndWriteAllStats
    /// </summary>
    public unsafe virtual void CopyAndWriteAllStats(BmSDK.BmGame.RPlayerController PC, BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqId, BmSDK.Engine.PlayerReplicationInfo PRI, BmSDK.Engine.OnlineStatsInterface StatsInterface)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.ROnlineStatsWrite.CopyAndWriteAllStats", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatsInterface, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CopyAllStats
    /// </summary>
    public unsafe virtual bool CopyAllStats(BmSDK.BmGame.RPlayerController PC, BmSDK.Engine.PlayerReplicationInfo PRI)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.ROnlineStatsWrite.CopyAllStats", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

}
