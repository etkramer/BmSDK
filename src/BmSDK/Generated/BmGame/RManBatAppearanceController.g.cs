#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RManBatAppearanceController<br/>
/// (flags = 0)
/// </summary>
public partial class RManBatAppearanceController : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RManBatAppearanceController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RManBatAppearanceController() { }

    /// <summary>
    /// Constructs a new RManBatAppearanceController
    /// </summary>
    public RManBatAppearanceController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RManBatAppearanceController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RManBatAppearanceController(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ChanceOfAppearanceByType
    /// </summary>
    public unsafe BmSDK.TArray<float> ChanceOfAppearanceByType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: AppearanceHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RManBatAppearanceController.FManbatAppearanceHistory> AppearanceHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RManBatAppearanceController.FManbatAppearanceHistory>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: MaxHistory
    /// </summary>
    public unsafe int MaxHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: ManbatAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> ManbatAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// Struct: FManbatAppearanceHistory
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FManbatAppearanceHistory
    {
        /// <summary>
        /// IntProperty: TimesAppeard
        /// </summary>
        public unsafe int TimesAppeard
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: AnimNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> AnimNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: TimeOfLastAppearance
        /// </summary>
        public unsafe float TimeOfLastAppearance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: MinTimeBetweenAppearances
        /// </summary>
        public unsafe float MinTimeBetweenAppearances
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: TypesOfAppearance
    /// </summary>
    public enum TypesOfAppearance
    {
        Manbat_Ledge = 0,
        Manbat_NumAppearanceTypes = 1,
        Manbat_MAX = 2,
    }
}
