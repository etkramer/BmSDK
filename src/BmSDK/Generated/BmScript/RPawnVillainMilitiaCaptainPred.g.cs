#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainMilitiaCaptainPred<br/>
/// (flags = 0)
/// </summary>
public partial class RPawnVillainMilitiaCaptainPred : BmSDK.BmScript.RPawnVillainGunPredFull, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainMilitiaCaptainPred", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainMilitiaCaptainPred() { }

    /// <summary>
    /// Constructs a new RPawnVillainMilitiaCaptainPred
    /// </summary>
    public RPawnVillainMilitiaCaptainPred(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainMilitiaCaptainPred Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainMilitiaCaptainPred(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMilitiaCaptainPred>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMilitiaCaptainPred>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMilitiaCaptainPred>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMilitiaCaptainPred>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMilitiaCaptainPred>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMilitiaCaptainPred>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMilitiaCaptainPred>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: DestroyMineController
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSpecialMoveConfig> DestroyMineController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSpecialMoveConfig>>(Ptr + 6808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6808); }
    }

    /// <summary>
    /// ObjectProperty: DestroyMineControllerNoCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DestroyMineControllerNoCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6824); }
    }

    /// <summary>
    /// ObjectProperty: ProximitySFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ProximitySFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// ComponentProperty: ControllerDevicePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ControllerDevicePFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }

    /// <summary>
    /// IntProperty: MineControllerIndex
    /// </summary>
    public unsafe int MineControllerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// BoolProperty: bBlockInteract
    /// </summary>
    public unsafe bool bBlockInteract
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6852) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6852); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6852); }
    }

    /// <summary>
    /// FloatProperty: InteractRange
    /// </summary>
    public unsafe float InteractRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6856); }
    }
}
