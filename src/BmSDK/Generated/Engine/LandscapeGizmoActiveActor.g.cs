#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LandscapeGizmoActiveActor<br/>
/// (size = 988)
/// (flags = 144703634)
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

    /// <summary>
    /// Gets the class default object as LandscapeGizmoActiveActor.
    /// </summary>
    public static LandscapeGizmoActiveActor DefaultObject => (LandscapeGizmoActiveActor)StaticClass().DefaultObject;

    internal LandscapeGizmoActiveActor() { }

    /// <summary>
    /// Constructs a new LandscapeGizmoActiveActor
    /// </summary>
    public LandscapeGizmoActiveActor(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LandscapeGizmoActiveActor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeGizmoActiveActor>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// ByteProperty: DataType
    /// </summary>
    public unsafe BmSDK.Engine.LandscapeGizmoActiveActor.ELandscapeGizmoType DataType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LandscapeGizmoActiveActor.ELandscapeGizmoType>(Ptr + 700); }
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
    public unsafe BmSDK.Engine.Texture2D GizmoTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ObjectProperty: GizmoMaterial
    /// </summary>
    public unsafe BmSDK.Engine.Material GizmoMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: GizmoDataMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance GizmoDataMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ObjectProperty: GizmoMeshMaterial
    /// </summary>
    public unsafe BmSDK.Engine.Material GizmoMeshMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: GizmoMeshMaterial2
    /// </summary>
    public unsafe BmSDK.Engine.Material GizmoMeshMaterial2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// StructProperty: TextureScale
    /// </summary>
    public unsafe ref System.Numerics.Vector2 TextureScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 816);

    /// <summary>
    /// ArrayProperty: SampledHeight
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> SampledHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ArrayProperty: SampledNormal
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> SampledNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 840); }
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
    /// InlineArray{StructProperty}: FrustumVerts
    /// </summary>
    public InlineArray<System.Numerics.Vector3> FrustumVerts => new(8, Ptr + 876);

    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FrustumVerts_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 876);
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FrustumVerts_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 888);
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FrustumVerts_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 900);
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FrustumVerts_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 912);
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FrustumVerts_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 924);
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FrustumVerts_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 936);
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FrustumVerts_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 948);
    /// <summary>
    /// StructProperty: FrustumVerts
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FrustumVerts_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 960);

    /// <summary>
    /// ArrayProperty: LayerNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> LayerNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// Struct: FGizmoSelectData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
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
    public enum ELandscapeGizmoType : byte
    {
        LGT_None = 0,
        LGT_Height = 1,
        LGT_Weight = 2,
        LGT_MAX = 3,
    }
}
