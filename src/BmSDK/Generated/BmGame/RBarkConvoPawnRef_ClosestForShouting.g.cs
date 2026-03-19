#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoPawnRef_ClosestForShouting<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBarkConvoPawnRef_ClosestForShouting : BmSDK.BmGame.RBarkConvoPawnRef, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoPawnRef_ClosestForShouting", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvoPawnRef_ClosestForShouting() { }

    /// <summary>
    /// Constructs a new RBarkConvoPawnRef_ClosestForShouting
    /// </summary>
    public RBarkConvoPawnRef_ClosestForShouting(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoPawnRef_ClosestForShouting Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoPawnRef_ClosestForShouting(nint ptr) : base(ptr) { }

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
    public unsafe BmSDK.TArray<BmSDK.FString> IndexToColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
}
