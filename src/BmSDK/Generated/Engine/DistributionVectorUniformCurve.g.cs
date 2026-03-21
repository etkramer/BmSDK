#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DistributionVectorUniformCurve<br/>
/// (size = 89)
/// (flags = 134230162)
/// </summary>
public partial class DistributionVectorUniformCurve : BmSDK.DistributionVector, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionVectorUniformCurve", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionVectorUniformCurve() { }

    /// <summary>
    /// Constructs a new DistributionVectorUniformCurve
    /// </summary>
    public DistributionVectorUniformCurve(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DistributionVectorUniformCurve Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionVectorUniformCurve(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DistributionVectorUniformCurve>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DistributionVectorUniformCurve>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DistributionVectorUniformCurve>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DistributionVectorUniformCurve>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DistributionVectorUniformCurve>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DistributionVectorUniformCurve>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DistributionVectorUniformCurve>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: ConstantCurve
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveTwoVectors ConstantCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveTwoVectors>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: bLockAxes1
    /// </summary>
    public unsafe bool bLockAxes1
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 80); }
    }

    /// <summary>
    /// BoolProperty: bLockAxes2
    /// </summary>
    public unsafe bool bLockAxes2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 80); }
    }

    /// <summary>
    /// BoolProperty: bUseExtremes
    /// </summary>
    public unsafe bool bUseExtremes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 80); }
    }

    /// <summary>
    /// ByteProperty: LockedAxes
    /// </summary>
    public unsafe BmSDK.DistributionVector.EDistributionVectorLockFlags LockedAxes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.EDistributionVectorLockFlags>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
    /// <summary>
    /// ByteProperty: LockedAxes
    /// </summary>
    public unsafe BmSDK.DistributionVector.EDistributionVectorLockFlags LockedAxes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.EDistributionVectorLockFlags>(Ptr + 85); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 85); }
    }

    /// <summary>
    /// ByteProperty: MirrorFlags
    /// </summary>
    public unsafe BmSDK.DistributionVector.EDistributionVectorMirrorFlags MirrorFlags_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.EDistributionVectorMirrorFlags>(Ptr + 86); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 86); }
    }
    /// <summary>
    /// ByteProperty: MirrorFlags
    /// </summary>
    public unsafe BmSDK.DistributionVector.EDistributionVectorMirrorFlags MirrorFlags_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.EDistributionVectorMirrorFlags>(Ptr + 87); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 87); }
    }
    /// <summary>
    /// ByteProperty: MirrorFlags
    /// </summary>
    public unsafe BmSDK.DistributionVector.EDistributionVectorMirrorFlags MirrorFlags_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.EDistributionVectorMirrorFlags>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
}
