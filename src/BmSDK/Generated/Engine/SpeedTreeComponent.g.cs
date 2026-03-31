#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SpeedTreeComponent<br/>
/// (size = 560)
/// (flags = 2290094226)
/// </summary>
public partial class SpeedTreeComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SpeedTreeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SpeedTreeComponent() { }

    /// <summary>
    /// Constructs a new SpeedTreeComponent
    /// </summary>
    public SpeedTreeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SpeedTreeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SpeedTreeComponent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SpeedTreeComponent>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SpeedTreeComponent>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SpeedTreeComponent>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SpeedTreeComponent>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SpeedTreeComponent>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SpeedTreeComponent>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SpeedTreeComponent>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SpeedTreeComponent>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: SetMaterial
    /// </summary>
    public unsafe virtual void SetMaterial(BmSDK.Engine.SpeedTreeComponent.ESpeedTreeMeshType MeshType, BmSDK.Engine.MaterialInterface Material)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SpeedTreeComponent.SetMaterial", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Material, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: GetMaterial
    /// </summary>
    public unsafe virtual BmSDK.Engine.MaterialInterface GetMaterial(BmSDK.Engine.SpeedTreeComponent.ESpeedTreeMeshType MeshType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SpeedTreeComponent.GetMaterial", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(paramsPtr + 4);
    }

    /// <summary>
    /// Struct: FSpeedTreeStaticLight
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FSpeedTreeStaticLight
    {
        /// <summary>
        /// StructProperty: Guid
        /// </summary>
        public unsafe ref BmSDK.GameObject.FGuid Guid
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FGuid>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// ObjectProperty: BranchShadowMap
        /// </summary>
        public unsafe BmSDK.Engine.ShadowMap1D BranchShadowMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ShadowMap1D>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: FrondShadowMap
        /// </summary>
        public unsafe BmSDK.Engine.ShadowMap1D FrondShadowMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ShadowMap1D>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: LeafMeshShadowMap
        /// </summary>
        public unsafe BmSDK.Engine.ShadowMap1D LeafMeshShadowMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ShadowMap1D>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: LeafCardShadowMap
        /// </summary>
        public unsafe BmSDK.Engine.ShadowMap1D LeafCardShadowMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ShadowMap1D>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: BillboardShadowMap
        /// </summary>
        public unsafe BmSDK.Engine.ShadowMap1D BillboardShadowMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ShadowMap1D>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: SpeedTree
    /// </summary>
    public unsafe BmSDK.Engine.SpeedTree SpeedTree
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpeedTree>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// BoolProperty: bUseLeafCards
    /// </summary>
    public unsafe bool bUseLeafCards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: bUseLeafMeshes
    /// </summary>
    public unsafe bool bUseLeafMeshes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: bUseBranches
    /// </summary>
    public unsafe bool bUseBranches
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: bUseFronds
    /// </summary>
    public unsafe bool bUseFronds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: bUseBillboards
    /// </summary>
    public unsafe bool bUseBillboards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: Lod3DStart
    /// </summary>
    public unsafe float Lod3DStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// FloatProperty: Lod3DEnd
    /// </summary>
    public unsafe float Lod3DEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// FloatProperty: LodBillboardStart
    /// </summary>
    public unsafe float LodBillboardStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: LodBillboardEnd
    /// </summary>
    public unsafe float LodBillboardEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: LodLevelOverride
    /// </summary>
    public unsafe float LodLevelOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ObjectProperty: Branch1Material
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface Branch1Material
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ObjectProperty: Branch2Material
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface Branch2Material
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// ObjectProperty: FrondMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface FrondMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ObjectProperty: LeafCardMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface LeafCardMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ObjectProperty: LeafMeshMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface LeafMeshMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ObjectProperty: BillboardMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface BillboardMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ObjectProperty: SpeedTreeIcon
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D SpeedTreeIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: StaticLights
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SpeedTreeComponent.FSpeedTreeStaticLight> StaticLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SpeedTreeComponent.FSpeedTreeStaticLight>>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// StructProperty: BranchLightMap
    /// </summary>
    public unsafe ref BmSDK.Engine.EngineTypes.FLightMapRef BranchLightMap
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.EngineTypes.FLightMapRef>(Ptr + 472);

    /// <summary>
    /// StructProperty: FrondLightMap
    /// </summary>
    public unsafe ref BmSDK.Engine.EngineTypes.FLightMapRef FrondLightMap
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.EngineTypes.FLightMapRef>(Ptr + 476);

    /// <summary>
    /// StructProperty: LeafMeshLightMap
    /// </summary>
    public unsafe ref BmSDK.Engine.EngineTypes.FLightMapRef LeafMeshLightMap
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.EngineTypes.FLightMapRef>(Ptr + 480);

    /// <summary>
    /// StructProperty: LeafCardLightMap
    /// </summary>
    public unsafe ref BmSDK.Engine.EngineTypes.FLightMapRef LeafCardLightMap
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.EngineTypes.FLightMapRef>(Ptr + 484);

    /// <summary>
    /// StructProperty: BillboardLightMap
    /// </summary>
    public unsafe ref BmSDK.Engine.EngineTypes.FLightMapRef BillboardLightMap
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.EngineTypes.FLightMapRef>(Ptr + 488);

    /// <summary>
    /// StructProperty: RotationOnlyMatrix
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMatrix RotationOnlyMatrix
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMatrix>(Ptr + 496);

    /// <summary>
    /// Enum: ESpeedTreeMeshType
    /// </summary>
    public enum ESpeedTreeMeshType
    {
        STMT_MinMinusOne = 0,
        STMT_Branches1 = 1,
        STMT_Branches2 = 2,
        STMT_Fronds = 3,
        STMT_LeafCards = 4,
        STMT_LeafMeshes = 5,
        STMT_Billboards = 6,
        STMT_Max = 7,
    }
}
