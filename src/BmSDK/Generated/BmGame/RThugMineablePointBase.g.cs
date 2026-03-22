#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RThugMineablePointBase<br/>
/// (size = 448)
/// (flags = 142606995)
/// </summary>
public partial class RThugMineablePointBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RThugMineablePointBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RThugMineablePointBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RThugMineablePointBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RThugMineablePointBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RThugMineablePointBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RThugMineablePointBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RThugMineablePointBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RThugMineablePointBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RThugMineablePointBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RThugMineablePointBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: GetStandPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetStandPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RThugMineablePointBase.GetStandPoint", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// BoolProperty: bValidPlacement
    /// </summary>
    public unsafe bool bValidPlacement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// ComponentProperty: GoodIcon
    /// </summary>
    public unsafe BmSDK.Engine.SpriteComponent GoodIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpriteComponent>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ComponentProperty: BadIcon
    /// </summary>
    public unsafe BmSDK.Engine.SpriteComponent BadIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpriteComponent>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// ObjectProperty: CurrentMine
    /// </summary>
    public unsafe BmSDK.BmGame.RThugMineBase CurrentMine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RThugMineBase>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ObjectProperty: AssignedMiner
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Search_Sub_MineLayer AssignedMiner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Search_Sub_MineLayer>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
}
