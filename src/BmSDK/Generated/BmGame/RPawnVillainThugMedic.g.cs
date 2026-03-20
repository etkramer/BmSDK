#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnVillainThugMedic<br/>
/// (flags = 0)
/// </summary>
public partial class RPawnVillainThugMedic : BmSDK.BmGame.RPawnVillainThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainThugMedic", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainThugMedic() { }

    /// <summary>
    /// Constructs a new RPawnVillainThugMedic
    /// </summary>
    public RPawnVillainThugMedic(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainThugMedic Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainThugMedic(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugMedic>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugMedic>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugMedic>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugMedic>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugMedic>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugMedic>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugMedic>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: CurrChargedUpVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain CurrChargedUpVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 6696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6696); }
    }

    /// <summary>
    /// ObjectProperty: MedicPackDisruptedXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MedicPackDisruptedXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6704); }
    }

    /// <summary>
    /// ObjectProperty: MedicPackXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MedicPackXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6712); }
    }

    /// <summary>
    /// ObjectProperty: JammedExplosionVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem JammedExplosionVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }

    /// <summary>
    /// ObjectProperty: JammedExplodeEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent JammedExplodeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6728); }
    }

    /// <summary>
    /// FloatProperty: LastChargedUpThugTime
    /// </summary>
    public unsafe float LastChargedUpThugTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6736); }
    }

    /// <summary>
    /// FloatProperty: LastChargedUpTime
    /// </summary>
    public unsafe float LastChargedUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6740); }
    }

    /// <summary>
    /// BoolProperty: bLastMedicIsRevive
    /// </summary>
    public unsafe bool bLastMedicIsRevive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6744) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6744); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6744); }
    }

    /// <summary>
    /// IntProperty: iMedicPackIndex
    /// </summary>
    public unsafe int iMedicPackIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6748); }
    }
}
