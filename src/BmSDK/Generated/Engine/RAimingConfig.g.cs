#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RAimingConfig<br/>
/// (size = 184)
/// (flags = 134221970)
/// </summary>
public partial class RAimingConfig : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RAimingConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAimingConfig.
    /// </summary>
    public static RAimingConfig DefaultObject => (RAimingConfig)StaticClass().DefaultObject;

    internal RAimingConfig() { }

    /// <summary>
    /// Constructs a new RAimingConfig
    /// </summary>
    public RAimingConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAimingConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAimingConfig(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAimingConfig>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAimingConfig>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAimingConfig>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAimingConfig>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAimingConfig>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAimingConfig>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAimingConfig>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAimingConfig>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Enum: EAimingReference
    /// </summary>
    public enum EAimingReference : byte
    {
        AR_Forward = 0,
        AR_Head = 1,
        AR_Gundummy = 2,
        AR_Gundummy02 = 3,
        AR_MAX = 4,
    }

    /// <summary>
    /// StructProperty: Spine
    /// </summary>
    public unsafe ref BmSDK.Engine.RAimingConfig.FAimingPartConfig Spine
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAimingConfig.FAimingPartConfig>(Ptr + 84);

    /// <summary>
    /// StructProperty: Head
    /// </summary>
    public unsafe ref BmSDK.Engine.RAimingConfig.FAimingPartConfig Head
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAimingConfig.FAimingPartConfig>(Ptr + 96);

    /// <summary>
    /// StructProperty: LeftArm
    /// </summary>
    public unsafe ref BmSDK.Engine.RAimingConfig.FAimingPartConfig LeftArm
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAimingConfig.FAimingPartConfig>(Ptr + 108);

    /// <summary>
    /// StructProperty: RightArm
    /// </summary>
    public unsafe ref BmSDK.Engine.RAimingConfig.FAimingPartConfig RightArm
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAimingConfig.FAimingPartConfig>(Ptr + 120);

    /// <summary>
    /// StructProperty: LookAt
    /// </summary>
    public unsafe ref BmSDK.Engine.RAimingConfig.FAimingPartConfig LookAt
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RAimingConfig.FAimingPartConfig>(Ptr + 132);

    /// <summary>
    /// ByteProperty: Reference
    /// </summary>
    public unsafe BmSDK.Engine.RAimingConfig.EAimingReference Reference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAimingConfig.EAimingReference>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: Reference_Axis
    /// </summary>
    public unsafe int Reference_Axis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: Reference_AxisNegate
    /// </summary>
    public unsafe bool Reference_AxisNegate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: Reference_YawOnly
    /// </summary>
    public unsafe bool Reference_YawOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: LookAt_Reference_YawOnly
    /// </summary>
    public unsafe bool LookAt_Reference_YawOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: Reference_PitchOffset
    /// </summary>
    public unsafe float Reference_PitchOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: LimitScale
    /// </summary>
    public unsafe float LimitScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: LookAt_LimitScale
    /// </summary>
    public unsafe float LookAt_LimitScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StrProperty: Notes
    /// </summary>
    public unsafe BmSDK.FString Notes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// Struct: FAimingPartConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FAimingPartConfig
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Yaw
        /// </summary>
        public unsafe float Yaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Pitch
        /// </summary>
        public unsafe float Pitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
