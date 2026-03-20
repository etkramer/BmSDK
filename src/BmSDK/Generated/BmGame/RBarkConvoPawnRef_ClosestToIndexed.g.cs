#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoPawnRef_ClosestToIndexed<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBarkConvoPawnRef_ClosestToIndexed : BmSDK.BmGame.RBarkConvoPawnRef, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoPawnRef_ClosestToIndexed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvoPawnRef_ClosestToIndexed() { }

    /// <summary>
    /// Constructs a new RBarkConvoPawnRef_ClosestToIndexed
    /// </summary>
    public RBarkConvoPawnRef_ClosestToIndexed(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoPawnRef_ClosestToIndexed Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoPawnRef_ClosestToIndexed(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: PawnIndex
    /// </summary>
    public unsafe int PawnIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: IndexToColour
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FColor> IndexToColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FColor>>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
}
