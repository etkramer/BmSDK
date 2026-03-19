#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LandscapeGizmoActiveActor<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LandscapeGizmoActiveActor : BmSDK.Engine.LandscapeGizmoActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LandscapeGizmoActiveActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LandscapeGizmoActiveActor() { }

    /// <summary>
    /// Constructs a new LandscapeGizmoActiveActor
    /// </summary>
    public LandscapeGizmoActiveActor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LandscapeGizmoActiveActor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LandscapeGizmoActiveActor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ByteProperty: DataType
    /// </summary>
    public unsafe byte DataType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// MapProperty: SelectedData
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ SelectedData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: GizmoTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GizmoTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ObjectProperty: GizmoMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GizmoMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: GizmoDataMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GizmoDataMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ObjectProperty: GizmoMeshMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GizmoMeshMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: GizmoMeshMaterial2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GizmoMeshMaterial2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// StructProperty: TextureScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TextureScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ArrayProperty: SampledHeight
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>> SampledHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ArrayProperty: SampledNormal
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> SampledNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: SampleSizeX
    /// </summary>
    public unsafe int SampleSizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// IntProperty: SampleSizeY
    /// </summary>
    public unsafe int SampleSizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: CachedWidth
    /// </summary>
    public unsafe float CachedWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: CachedHeight
    /// </summary>
    public unsafe float CachedHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// FloatProperty: CachedScaleXY
    /// </summary>
    public unsafe float CachedScaleXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FrustumVerts_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FrustumVerts_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FrustumVerts_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FrustumVerts_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FrustumVerts_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FrustumVerts_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FrustumVerts_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FrustumVerts_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: LayerNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> LayerNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// Struct: FGizmoSelectData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FGizmoSelectData
    {
        /// <summary>
        /// FloatProperty: Ratio
        /// </summary>
        public unsafe float Ratio
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: HeightData
        /// </summary>
        public unsafe float HeightData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// MapProperty: WeightDataMap
        /// </summary>
        public unsafe BmSDK.TMap<object, object> /* TODO */ WeightDataMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: ELandscapeGizmoType
    /// </summary>
    public enum ELandscapeGizmoType
    {
        LGT_None = 0,
        LGT_Height = 1,
        LGT_Weight = 2,
        LGT_MAX = 3,
    }
}
