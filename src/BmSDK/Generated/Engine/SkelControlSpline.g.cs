#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControlSpline<br/>
/// (size = 192)
/// (flags = 142606482)
/// </summary>
public partial class SkelControlSpline : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControlSpline", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkelControlSpline() { }

    /// <summary>
    /// Constructs a new SkelControlSpline
    /// </summary>
    public SkelControlSpline(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControlSpline Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControlSpline(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkelControlSpline>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkelControlSpline>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkelControlSpline>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkelControlSpline>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkelControlSpline>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkelControlSpline>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkelControlSpline>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Enum: ESplineControlRotMode
    /// </summary>
    public enum ESplineControlRotMode
    {
        SCR_NoChange = 0,
        SCR_AlongSpline = 1,
        SCR_Interpolate = 2,
        SCR_MAX = 3,
    }

    /// <summary>
    /// IntProperty: SplineLength
    /// </summary>
    public unsafe int SplineLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ByteProperty: SplineBoneAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis SplineBoneAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ByteProperty: BoneRotMode
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSpline.ESplineControlRotMode BoneRotMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSpline.ESplineControlRotMode>(Ptr + 177); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 177); }
    }

    /// <summary>
    /// BoolProperty: bInvertSplineBoneAxis
    /// </summary>
    public unsafe bool bInvertSplineBoneAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: EndSplineTension
    /// </summary>
    public unsafe float EndSplineTension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// FloatProperty: StartSplineTension
    /// </summary>
    public unsafe float StartSplineTension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
}
