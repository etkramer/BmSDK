#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexDestructibleDamageParameters<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ApexDestructibleDamageParameters : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexDestructibleDamageParameters", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexDestructibleDamageParameters() { }

    /// <summary>
    /// Constructs a new ApexDestructibleDamageParameters
    /// </summary>
    public ApexDestructibleDamageParameters(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexDestructibleDamageParameters Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexDestructibleDamageParameters(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: DamageMap
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT DamageMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// Struct: FDamagePair
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FDamagePair
    {
        /// <summary>
        /// ClassProperty: DamageType
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DamageType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Params
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Params
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FDamageParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FDamageParameters
    {
        /// <summary>
        /// ByteProperty: OverrideMode
        /// </summary>
        public unsafe byte OverrideMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: BaseDamage
        /// </summary>
        public unsafe float BaseDamage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Radius
        /// </summary>
        public unsafe float Radius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: Momentum
        /// </summary>
        public unsafe float Momentum
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: EDamageParameterOverrideMode
    /// </summary>
    public enum EDamageParameterOverrideMode
    {
        DPOM_NoDamage = 0,
        DPOM_Absolute = 1,
        DPOM_Multiplier = 2,
        DPOM_MAX = 3,
    }
}
