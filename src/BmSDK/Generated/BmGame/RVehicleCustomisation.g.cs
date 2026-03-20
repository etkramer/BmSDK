#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleCustomisation<br/>
/// (size = 128)
/// (flags = 142606482)
/// </summary>
public partial class RVehicleCustomisation : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleCustomisation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleCustomisation() { }

    /// <summary>
    /// Constructs a new RVehicleCustomisation
    /// </summary>
    public RVehicleCustomisation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleCustomisation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleCustomisation(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SetupDeadVehicleMaterials
    /// </summary>
    public unsafe virtual void SetupDeadVehicleMaterials(BmSDK.Engine.SkeletalMeshComponent SkeletalMeshComponent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleCustomisation.SetupDeadVehicleMaterials", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkeletalMeshComponent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetupCustomisationOptions
    /// </summary>
    public unsafe virtual void SetupCustomisationOptions(BmSDK.Engine.SkeletalMeshComponent SkeletalMeshComponent, int ForceMaterialIndex = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleCustomisation.SetupCustomisationOptions", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkeletalMeshComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceMaterialIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// NameProperty: RoofRackSocket
    /// </summary>
    public unsafe BmSDK.FName RoofRackSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: CustomisationGroups
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleCustomisation.FCarCustomisationObject> CustomisationGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleCustomisation.FCarCustomisationObject>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ComponentProperty: RoofRackObject
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent RoofRackObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bDoCustomisations
    /// </summary>
    public unsafe bool bDoCustomisations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: PickedIndex
    /// </summary>
    public unsafe int PickedIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// IntProperty: PickedMatIndex
    /// </summary>
    public unsafe int PickedMatIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// Struct: FCarCustomisationObject
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FCarCustomisationObject
    {
        /// <summary>
        /// ObjectProperty: RoofRackObject
        /// </summary>
        public unsafe BmSDK.Engine.StaticMesh RoofRackObject
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: RoofRackMaterials
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleCustomisation.FCarCustomisationMaterialParam> RoofRackMaterials
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleCustomisation.FCarCustomisationMaterialParam>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: Materials
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleCustomisation.FCarCustomisationMaterialParam> Materials
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleCustomisation.FCarCustomisationMaterialParam>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FCarCustomisationMaterialParam
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FCarCustomisationMaterialParam
    {
        /// <summary>
        /// ArrayProperty: OverrideMaterials
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstance> OverrideMaterials
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstance>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: DeadMaterials
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstance> DeadMaterials
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstance>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
