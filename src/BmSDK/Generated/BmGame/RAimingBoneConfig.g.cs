#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAimingBoneConfig<br/>
/// (size = 404)
/// (flags = 134217874)
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// StructProperty: Spine1
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Spine1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// StructProperty: Spine2
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Spine2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StructProperty: Spine3
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Spine3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StructProperty: Neck
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Neck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// StructProperty: Head
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Head
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: LeftClavicle
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues LeftClavicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// StructProperty: LeftUpperArm
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues LeftUpperArm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// StructProperty: RightClavicle
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues RightClavicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// StructProperty: RightUpperArm
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues RightUpperArm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// Struct: FAimingBoneValues
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
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
        /// StructProperty: PositiveLimit
        /// </summary>
        public unsafe System.Numerics.Vector3 PositiveLimit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: NegativeLimit
        /// </summary>
        public unsafe System.Numerics.Vector3 NegativeLimit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }
}
