#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RClayfaceDrips<br/>
/// (size = 764)
/// (flags = 8388626)
/// </summary>
public partial class RClayfaceDrips : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RClayfaceDrips", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RClayfaceDrips() { }

    /// <summary>
    /// Constructs a new RClayfaceDrips
    /// </summary>
    public RClayfaceDrips(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RClayfaceDrips Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RClayfaceDrips(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe void Initialise(BmSDK.Engine.Actor Ri)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RClayfaceDrips.Initialise", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ri, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe void Update(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RClayfaceDrips.Update", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnEmitter
    /// </summary>
    public unsafe BmSDK.BmGame.REmitter SpawnEmitter(BmSDK.Engine.ParticleSystem Template, BmSDK.Engine.SkeletalMeshComponent AttachMesh, BmSDK.FName BoneName, float BoneTranslationScale = default, float DrawScale = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RClayfaceDrips.SpawnEmitter", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttachMesh, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneTranslationScale, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawScale, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REmitter>(paramsPtr + 24);
    }

    /// <summary>
    /// StructProperty: Drips
    /// </summary>
    public unsafe BmSDK.BmScript.RClayfaceDrips.FRDripPool Drips
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RClayfaceDrips.FRDripPool>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// Struct: FRDripPool
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 720)]
    public partial record struct FRDripPool
    {
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.BmGame.REmitter Pool
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REmitter>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: TimeRunning
        /// </summary>
        public unsafe float TimeRunning
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// NameProperty: AttachBone
        /// </summary>
        public unsafe BmSDK.FName AttachBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }; }
        }

        /// <summary>
        /// FloatProperty: AttachBoneScale
        /// </summary>
        public unsafe float AttachBoneScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }; }
        }

        /// <summary>
        /// ComponentProperty: AttachMesh
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMeshComponent AttachMesh
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 600); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }; }
        }
    }

}
