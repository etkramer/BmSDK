#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackInstFloatMaterialParam<br/>
/// (size = 60)
/// (flags = 134217874)
/// </summary>
public partial class InterpTrackInstFloatMaterialParam : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackInstFloatMaterialParam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstFloatMaterialParam() { }

    /// <summary>
    /// Constructs a new InterpTrackInstFloatMaterialParam
    /// </summary>
    public InterpTrackInstFloatMaterialParam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstFloatMaterialParam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstFloatMaterialParam(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: MICInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrackInstFloatMaterialParam.FFloatMaterialParamMICData> MICInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrackInstFloatMaterialParam.FFloatMaterialParamMICData>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ObjectProperty: InstancedTrack
    /// </summary>
    public unsafe BmSDK.Engine.InterpTrackFloatMaterialParam InstancedTrack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpTrackFloatMaterialParam>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// Struct: FFloatMaterialParamMICData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FFloatMaterialParamMICData
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
        /// ArrayProperty: MICResetFloats
        /// </summary>
        public unsafe BmSDK.TArray<float> MICResetFloats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
