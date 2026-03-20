#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CopyHeightsToRGBEffect<br/>
/// (flags = 0)
/// </summary>
public partial class CopyHeightsToRGBEffect : BmSDK.Engine.PostProcessEffect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CopyHeightsToRGBEffect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal CopyHeightsToRGBEffect() { }

    /// <summary>
    /// Constructs a new CopyHeightsToRGBEffect
    /// </summary>
    public CopyHeightsToRGBEffect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CopyHeightsToRGBEffect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CopyHeightsToRGBEffect(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bDustVolumeSet
    /// </summary>
    public unsafe bool bDustVolumeSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bIsDirectionalShadowCopy
    /// </summary>
    public unsafe bool bIsDirectionalShadowCopy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bUseOverrideComposite
    /// </summary>
    public unsafe bool bUseOverrideComposite
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: ShadowGroundPlane
    /// </summary>
    public unsafe System.Numerics.Vector4 ShadowGroundPlane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector4>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StructProperty: overrideRTTop
    /// </summary>
    public unsafe System.IntPtr overrideRTTop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
}
