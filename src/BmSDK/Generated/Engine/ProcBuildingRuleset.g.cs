#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ProcBuildingRuleset<br/>
/// (size = 128)
/// (flags = 136315026)
/// </summary>
public partial class ProcBuildingRuleset : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ProcBuildingRuleset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ProcBuildingRuleset() { }

    /// <summary>
    /// Constructs a new ProcBuildingRuleset
    /// </summary>
    public ProcBuildingRuleset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ProcBuildingRuleset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ProcBuildingRuleset(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EProcBuildingAxis
    /// </summary>
    public enum EProcBuildingAxis
    {
        EPBAxis_X = 0,
        EPBAxis_Z = 1,
        EPBAxis_MAX = 2,
    }

    /// <summary>
    /// Struct: FPBParamSwatch
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FPBParamSwatch
    {
        /// <summary>
        /// NameProperty: SwatchName
        /// </summary>
        public unsafe BmSDK.FName SwatchName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Params
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBMaterialParam> Params
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBMaterialParam>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FPBVariationInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FPBVariationInfo
    {
        /// <summary>
        /// NameProperty: VariationName
        /// </summary>
        public unsafe BmSDK.FName VariationName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bMeshOnTopOfFacePoly
        /// </summary>
        public unsafe bool bMeshOnTopOfFacePoly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: RootRule
    /// </summary>
    public unsafe BmSDK.Engine.PBRuleNodeBase RootRule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PBRuleNodeBase>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: bBeingEdited
    /// </summary>
    public unsafe bool bBeingEdited
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bEnableInteriorTexture
    /// </summary>
    public unsafe bool bEnableInteriorTexture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bLODOnlyRoof
    /// </summary>
    public unsafe bool bLODOnlyRoof
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bPickRandomSwatch
    /// </summary>
    public unsafe bool bPickRandomSwatch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// ObjectProperty: DefaultRoofMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DefaultRoofMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ObjectProperty: DefaultFloorMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DefaultFloorMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ObjectProperty: DefaultNonRectWallMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DefaultNonRectWallMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// FloatProperty: RoofZOffset
    /// </summary>
    public unsafe float RoofZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: NotRoofZOffset
    /// </summary>
    public unsafe float NotRoofZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// FloatProperty: FloorZOffset
    /// </summary>
    public unsafe float FloorZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// FloatProperty: NotFloorZOffset
    /// </summary>
    public unsafe float NotFloorZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// FloatProperty: RoofPolyInset
    /// </summary>
    public unsafe float RoofPolyInset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// FloatProperty: FloorPolyInset
    /// </summary>
    public unsafe float FloorPolyInset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: BuildingLODSpecular
    /// </summary>
    public unsafe float BuildingLODSpecular
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// FloatProperty: RoofEdgeScopeRaise
    /// </summary>
    public unsafe float RoofEdgeScopeRaise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: LODCubemap
    /// </summary>
    public unsafe BmSDK.Engine.Texture LODCubemap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ObjectProperty: InteriorTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture InteriorTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: Variations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuildingRuleset.FPBVariationInfo> Variations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuildingRuleset.FPBVariationInfo>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: ParamSwatches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuildingRuleset.FPBParamSwatch> ParamSwatches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuildingRuleset.FPBParamSwatch>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
}
