#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleLightEnvironmentComponent<br/>
/// (size = 296)
/// (flags = 142606482)
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// BoolProperty: bAllowDLESharing
    /// </summary>
    public unsafe bool bAllowDLESharing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }
}
