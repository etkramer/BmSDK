#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSkelControl_PositionConstraint<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSkelControl_PositionConstraint : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSkelControl_PositionConstraint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSkelControl_PositionConstraint() { }

    /// <summary>
    /// Constructs a new RSkelControl_PositionConstraint
    /// </summary>
    public RSkelControl_PositionConstraint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSkelControl_PositionConstraint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSkelControl_PositionConstraint(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: SourceBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> SourceBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// BoolProperty: ApplyPosition
    /// </summary>
    public unsafe bool ApplyPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: ApplyOrientation
    /// </summary>
    public unsafe bool ApplyOrientation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// ArrayProperty: ResolvedSourceBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> ResolvedSourceBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// Struct: FPositionConstraintBone
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FPositionConstraintBone
    {
        /// <summary>
        /// NameProperty: Name
        /// </summary>
        public unsafe BmSDK.FName Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Weight
        /// </summary>
        public unsafe float Weight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
