#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAimingBoneConfig<br/>
/// (flags = 0)
/// </summary>
public partial class RAimingBoneConfig : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAimingBoneConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAimingBoneConfig() { }

    /// <summary>
    /// Constructs a new RAimingBoneConfig
    /// </summary>
    public RAimingBoneConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAimingBoneConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAimingBoneConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Spine
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Spine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: Spine1
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Spine1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: Spine2
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Spine2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StructProperty: Spine3
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Spine3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: Neck
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Neck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StructProperty: Head
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Head
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// StructProperty: LeftClavicle
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues LeftClavicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StructProperty: LeftUpperArm
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues LeftUpperArm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// StructProperty: RightClavicle
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues RightClavicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StructProperty: RightUpperArm
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues RightUpperArm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// Struct: FAimingBoneValues
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FAimingBoneValues
    {
        /// <summary>
        /// StructProperty: GroupProportion
        /// </summary>
        public unsafe System.Numerics.Vector3 GroupProportion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: EnableLimit
        /// </summary>
        public unsafe bool EnableLimit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: PositiveLimit
        /// </summary>
        public unsafe System.Numerics.Vector3 PositiveLimit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: NegativeLimit
        /// </summary>
        public unsafe System.Numerics.Vector3 NegativeLimit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }
}
