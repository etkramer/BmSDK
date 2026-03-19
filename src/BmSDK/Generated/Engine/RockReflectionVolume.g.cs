#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RockReflectionVolume<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RockReflectionVolume : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RockReflectionVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RockReflectionVolume() { }

    /// <summary>
    /// Constructs a new RockReflectionVolume
    /// </summary>
    public RockReflectionVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RockReflectionVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RockReflectionVolume(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RockReflectionVolume>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockReflectionVolume>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RockReflectionVolume>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockReflectionVolume>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockReflectionVolume>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RockReflectionVolume>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockReflectionVolume>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: ReflectionBoxInfo
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReflectionBoxInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ComponentProperty: SceneCapture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SceneCapture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ComponentProperty: StaticMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// IntProperty: PrecomputedResolution
    /// </summary>
    public unsafe int PrecomputedResolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: HighDynamicRangeMax
    /// </summary>
    public unsafe float HighDynamicRangeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// IntProperty: Priority
    /// </summary>
    public unsafe int Priority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: FadeRange
    /// </summary>
    public unsafe float FadeRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: FadeAmount
    /// </summary>
    public unsafe float FadeAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// BoolProperty: bAllowAutoUpdate
    /// </summary>
    public unsafe bool bAllowAutoUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bIncludeAverageReflection
    /// </summary>
    public unsafe bool bIncludeAverageReflection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bIsInteriorMappingProbe
    /// </summary>
    public unsafe bool bIsInteriorMappingProbe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 996); }
    }

    /// <summary>
    /// Struct: FFReflectionBoxInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FFReflectionBoxInfo
    {
        /// <summary>
        /// StructProperty: Bounds
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Bounds
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ReflectionBoxToUnitCube
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReflectionBoxToUnitCube
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: UnitCubeToReflectionBox
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UnitCubeToReflectionBox
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// StructProperty: BoxBasis
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BoxBasis
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }; }
        }

        /// <summary>
        /// StructProperty: BoxCentre
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BoxCentre
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }; }
        }

        /// <summary>
        /// ObjectProperty: TextureTarget
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TextureTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 236); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }; }
        }

        /// <summary>
        /// ObjectProperty: TextureCube
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TextureCube
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 244); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }; }
        }

        /// <summary>
        /// StructProperty: HDRScale
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HDRScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 252); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }; }
        }

        /// <summary>
        /// StructProperty: HDROffset
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HDROffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }; }
        }
    }
}
