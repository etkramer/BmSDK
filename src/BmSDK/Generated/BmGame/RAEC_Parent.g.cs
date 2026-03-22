#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Parent<br/>
/// (size = 468)
/// (flags = 8388626)
/// </summary>
public partial class RAEC_Parent : BmSDK.BmGame.RAlertEventCoordinatorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Parent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAEC_Parent() { }

    /// <summary>
    /// Constructs a new RAEC_Parent
    /// </summary>
    public RAEC_Parent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAEC_Parent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Parent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Parent>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Parent>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Parent>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Parent>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Parent>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Parent>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Parent>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: AssignToEvent
    /// </summary>
    public unsafe override void AssignToEvent(BmSDK.BmGame.RBMAIController Con)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Parent.AssignToEvent", true);
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Con, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNewFearLevel
    /// </summary>
    public unsafe virtual void SetNewFearLevel(BmSDK.BmGame.RBMRoomAIState.VillainFearLevel NewFearLevel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Parent.SetNewFearLevel", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFearLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetRoom
    /// </summary>
    public unsafe virtual void SetRoom(BmSDK.BmGame.RBMRoomAIState NewRoomState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Parent.SetRoom", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRoomState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: SearchCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_SearchBase SearchCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_SearchBase>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ObjectProperty: AttackCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Base AttackCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Base>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: BatarangReactionCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_BatarangReaction BatarangReactionCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_BatarangReaction>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ObjectProperty: DisarmedCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Disarmed DisarmedCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Disarmed>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }
}
