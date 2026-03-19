#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHidePoint_LampPostTop<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHidePoint_LampPostTop : BmSDK.BmGame.RHidePoint_Walkable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHidePoint_LampPostTop", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHidePoint_LampPostTop() { }

    /// <summary>
    /// Constructs a new RHidePoint_LampPostTop
    /// </summary>
    public RHidePoint_LampPostTop(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHidePoint_LampPostTop Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHidePoint_LampPostTop(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint_LampPostTop>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: CollisionShape
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CollisionShape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: ChanceOfJokerHallucination
    /// </summary>
    public unsafe float ChanceOfJokerHallucination
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenJokerHallucinationOverlays
    /// </summary>
    public unsafe float TimeBetweenJokerHallucinationOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// BoolProperty: bJokerInNervousPose
    /// </summary>
    public unsafe bool bJokerInNervousPose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1304); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1304); }
    }

    /// <summary>
    /// StructProperty: BeamEnd1
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BeamEnd1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// StructProperty: BeamEnd2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BeamEnd2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ObjectProperty: AxisMatinee
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AxisMatinee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// FloatProperty: CurrentSpeed
    /// </summary>
    public unsafe float CurrentSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: DesiredAnimSpeed
    /// </summary>
    public unsafe float DesiredAnimSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: XAxisSpeed
    /// </summary>
    public unsafe float XAxisSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: AccelTime
    /// </summary>
    public unsafe float AccelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }
}
