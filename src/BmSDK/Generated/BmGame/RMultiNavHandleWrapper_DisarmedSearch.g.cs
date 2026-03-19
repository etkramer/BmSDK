#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMultiNavHandleWrapper_DisarmedSearch<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RMultiNavHandleWrapper_DisarmedSearch : BmSDK.BmGame.RMultiNavHandleWrapper, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMultiNavHandleWrapper_DisarmedSearch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMultiNavHandleWrapper_DisarmedSearch() { }

    /// <summary>
    /// Constructs a new RMultiNavHandleWrapper_DisarmedSearch
    /// </summary>
    public RMultiNavHandleWrapper_DisarmedSearch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMultiNavHandleWrapper_DisarmedSearch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMultiNavHandleWrapper_DisarmedSearch(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: GunSourceActorList
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> GunSourceActorList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
