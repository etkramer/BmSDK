#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackInstVectorMaterialParam<br/>
/// (flags = 0)
/// </summary>
public partial class InterpTrackInstVectorMaterialParam : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackInstVectorMaterialParam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstVectorMaterialParam() { }

    /// <summary>
    /// Constructs a new InterpTrackInstVectorMaterialParam
    /// </summary>
    public InterpTrackInstVectorMaterialParam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstVectorMaterialParam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstVectorMaterialParam(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: MICInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrackInstVectorMaterialParam.FVectorMaterialParamMICData> MICInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrackInstVectorMaterialParam.FVectorMaterialParamMICData>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: GroupActorPrimitiveData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrackInstVectorMaterialParam.FVectorMaterialParamPrimitiveData> GroupActorPrimitiveData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrackInstVectorMaterialParam.FVectorMaterialParamPrimitiveData>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: InstancedTrack
    /// </summary>
    public unsafe BmSDK.Engine.InterpTrackVectorMaterialParam InstancedTrack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpTrackVectorMaterialParam>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// Struct: FVectorMaterialParamMICData
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FVectorMaterialParamMICData
    {
        /// <summary>
        /// ArrayProperty: MICs
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> MICs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: MICResetVectors
        /// </summary>
        public unsafe BmSDK.TArray<System.Numerics.Vector3> MICResetVectors
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
