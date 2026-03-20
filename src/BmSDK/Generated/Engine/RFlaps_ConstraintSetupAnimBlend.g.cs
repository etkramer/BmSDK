#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RFlaps_ConstraintSetupAnimBlend<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RFlaps_ConstraintSetupAnimBlend : BmSDK.Engine.RFlaps_ConstraintSetup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RFlaps_ConstraintSetupAnimBlend", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFlaps_ConstraintSetupAnimBlend() { }

    /// <summary>
    /// Constructs a new RFlaps_ConstraintSetupAnimBlend
    /// </summary>
    public RFlaps_ConstraintSetupAnimBlend(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFlaps_ConstraintSetupAnimBlend Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFlaps_ConstraintSetupAnimBlend(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ConstrainedParticle
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: ConstraintRadius
    /// </summary>
    public unsafe float ConstraintRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StructProperty: BlendDatas
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData BlendDatas_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
    /// <summary>
    /// StructProperty: BlendDatas
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData BlendDatas_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// StructProperty: BlendDatas
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData BlendDatas_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// StructProperty: BlendDatas
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData BlendDatas_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
    /// <summary>
    /// StructProperty: BlendDatas
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData BlendDatas_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// Struct: FRBlendBoneData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FRBlendBoneData
    {
        /// <summary>
        /// NameProperty: ConstraintFrameBoneName
        /// </summary>
        public unsafe BmSDK.FName ConstraintFrameBoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: BlendWeight
        /// </summary>
        public unsafe float BlendWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

}
