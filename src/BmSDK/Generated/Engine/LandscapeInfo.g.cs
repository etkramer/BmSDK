#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LandscapeInfo<br/>
/// (size = 784)
/// (flags = 134217874)
/// </summary>
public partial class LandscapeInfo : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LandscapeInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as LandscapeInfo.
    /// </summary>
    public static LandscapeInfo DefaultObject => (LandscapeInfo)StaticClass().DefaultObject;

    internal LandscapeInfo() { }

    /// <summary>
    /// Constructs a new LandscapeInfo
    /// </summary>
    public LandscapeInfo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LandscapeInfo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LandscapeInfo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeInfo>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeInfo>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeInfo>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeInfo>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeInfo>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeInfo>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<LandscapeInfo>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<LandscapeInfo>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Struct: FLandscapeAddCollision
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FLandscapeAddCollision
    {
        /// <summary>
        /// StructProperty: Corners
        /// </summary>
        public unsafe System.Numerics.Vector3 Corners_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// StructProperty: Corners
        /// </summary>
        public unsafe System.Numerics.Vector3 Corners_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// StructProperty: Corners
        /// </summary>
        public unsafe System.Numerics.Vector3 Corners_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// StructProperty: Corners
        /// </summary>
        public unsafe System.Numerics.Vector3 Corners_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// StructProperty: LandscapeGuid
    /// </summary>
    public unsafe ref BmSDK.GameObject.FGuid LandscapeGuid
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FGuid>(Ptr + 84);

    /// <summary>
    /// MapProperty: LayerInfoMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ LayerInfoMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: DataInterface
    /// </summary>
    public unsafe System.IntPtr DataInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// MapProperty: XYtoComponentMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ XYtoComponentMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// MapProperty: XYtoCollisionComponentMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ XYtoCollisionComponentMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ObjectProperty: LandscapeProxy
    /// </summary>
    public unsafe BmSDK.Engine.LandscapeProxy LandscapeProxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LandscapeProxy>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// MapProperty: XYtoAddCollisionMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ XYtoAddCollisionMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// StructProperty: Proxies
    /// </summary>
    public unsafe ref BmSDK.GameObject.FSet_Mirror Proxies
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FSet_Mirror>(Ptr + 404);

    /// <summary>
    /// StructProperty: SelectedComponents
    /// </summary>
    public unsafe ref BmSDK.GameObject.FSet_Mirror SelectedComponents
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FSet_Mirror>(Ptr + 476);

    /// <summary>
    /// StructProperty: SelectedCollisionComponents
    /// </summary>
    public unsafe ref BmSDK.GameObject.FSet_Mirror SelectedCollisionComponents
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FSet_Mirror>(Ptr + 548);

    /// <summary>
    /// StructProperty: SelectedRegionComponents
    /// </summary>
    public unsafe ref BmSDK.GameObject.FSet_Mirror SelectedRegionComponents
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FSet_Mirror>(Ptr + 620);

    /// <summary>
    /// MapProperty: SelectedRegion
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ SelectedRegion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// StrProperty: HeightmapFilePath
    /// </summary>
    public unsafe BmSDK.FString HeightmapFilePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bIsValid
    /// </summary>
    public unsafe bool bIsValid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }
}
