#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoPawnRef_BestForFlagType<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBarkConvoPawnRef_BestForFlagType : BmSDK.BmGame.RBarkConvoPawnRef, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoPawnRef_BestForFlagType", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvoPawnRef_BestForFlagType() { }

    /// <summary>
    /// Constructs a new RBarkConvoPawnRef_BestForFlagType
    /// </summary>
    public RBarkConvoPawnRef_BestForFlagType(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoPawnRef_BestForFlagType Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoPawnRef_BestForFlagType(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: FlagType
    /// </summary>
    public unsafe byte FlagType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bAllowNoFlagFoundFallback
    /// </summary>
    public unsafe bool bAllowNoFlagFoundFallback
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }
}
