#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleLightEnvironmentComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleLightEnvironmentComponent : BmSDK.Engine.DynamicLightEnvironmentComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleLightEnvironmentComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleLightEnvironmentComponent() { }

    /// <summary>
    /// Constructs a new ParticleLightEnvironmentComponent
    /// </summary>
    public ParticleLightEnvironmentComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleLightEnvironmentComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleLightEnvironmentComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: ReferenceCount
    /// </summary>
    public unsafe int ReferenceCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// IntProperty: NumPooledReuses
    /// </summary>
    public unsafe int NumPooledReuses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// ObjectProperty: SharedInstigator
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SharedInstigator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ObjectProperty: SharedParticleSystem
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SharedParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// BoolProperty: bAllowDLESharing
    /// </summary>
    public unsafe bool bAllowDLESharing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 364); }
    }
}
