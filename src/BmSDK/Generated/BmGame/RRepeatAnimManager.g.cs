#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRepeatAnimManager<br/>
/// (flags = 0)
/// </summary>
public partial class RRepeatAnimManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRepeatAnimManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRepeatAnimManager() { }

    /// <summary>
    /// Constructs a new RRepeatAnimManager
    /// </summary>
    public RRepeatAnimManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRepeatAnimManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRepeatAnimManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AnimHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRepeatAnimManager.FRAM_AnimTime> AnimHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRepeatAnimManager.FRAM_AnimTime>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: HardLockoutTime
    /// </summary>
    public unsafe float HardLockoutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: SoftLockoutTime
    /// </summary>
    public unsafe float SoftLockoutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// Struct: FRAM_AnimTime
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRAM_AnimTime
    {
        /// <summary>
        /// NameProperty: Anim
        /// </summary>
        public unsafe BmSDK.FName Anim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
