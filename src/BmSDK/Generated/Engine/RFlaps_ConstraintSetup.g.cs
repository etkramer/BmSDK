#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RFlaps_ConstraintSetup<br/>
/// (flags = 0)
/// </summary>
public partial class RFlaps_ConstraintSetup : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RFlaps_ConstraintSetup", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFlaps_ConstraintSetup() { }

    /// <summary>
    /// Constructs a new RFlaps_ConstraintSetup
    /// </summary>
    public RFlaps_ConstraintSetup(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFlaps_ConstraintSetup Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFlaps_ConstraintSetup(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe BmSDK.Engine.RFlapsAsset Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlapsAsset>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bDisable
    /// </summary>
    public unsafe bool bDisable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// StrProperty: ConstraintDescription
    /// </summary>
    public unsafe BmSDK.FString ConstraintDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// Enum: ERFlapsConstraintType
    /// </summary>
    public enum ERFlapsConstraintType
    {
        RFCT_Anim = 0,
        RFCT_AnimBlend = 1,
        RFCT_Distance = 2,
        RFCT_Plane = 3,
        RFCT_Spring = 4,
        RFCT_Collision = 5,
        RFCT_Cone = 6,
        RFCT_MAX = 7,
    }

    /// <summary>
    /// Struct: FRFlapsParticleReference
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRFlapsParticleReference
    {
        /// <summary>
        /// NameProperty: BodyName
        /// </summary>
        public unsafe BmSDK.FName BodyName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: ParticleName
        /// </summary>
        public unsafe BmSDK.FName ParticleName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
