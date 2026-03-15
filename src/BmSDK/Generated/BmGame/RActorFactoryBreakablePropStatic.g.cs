#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RActorFactoryBreakablePropStatic<br/>
/// (size = 204)
/// (flags = 142618774)
/// </summary>
public partial class RActorFactoryBreakablePropStatic : BmSDK.Engine.ActorFactoryRigidBody, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RActorFactoryBreakablePropStatic", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RActorFactoryBreakablePropStatic() { }

    /// <summary>
    /// Constructs a new RActorFactoryBreakablePropStatic
    /// </summary>
    public RActorFactoryBreakablePropStatic(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RActorFactoryBreakablePropStatic Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RActorFactoryBreakablePropStatic(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: BreakablePropDamage
    /// </summary>
    public unsafe BmSDK.BmGame.RActorFactoryBreakablePropStatic.FDamageDef BreakablePropDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RActorFactoryBreakablePropStatic.FDamageDef>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ArrayProperty: RandomVariation
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RActorFactoryBreakablePropStatic.FBreakablePropDef> RandomVariation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RActorFactoryBreakablePropStatic.FBreakablePropDef>>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// Struct: FBreakablePropDef
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FBreakablePropDef
    {
        /// <summary>
        /// ObjectProperty: StaticMesh
        /// </summary>
        public unsafe BmSDK.Engine.StaticMesh StaticMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FDamageDef
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FDamageDef
    {
        /// <summary>
        /// ArrayProperty: DamageStages
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBreakablePropStatic.FDamageStage> DamageStages
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBreakablePropStatic.FDamageStage>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: DamageTypes
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Class> DamageTypes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ArrayProperty: IgnoreDamageTypes
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Class> IgnoreDamageTypes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: CollideDamageScale
        /// </summary>
        public unsafe float CollideDamageScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }
}
