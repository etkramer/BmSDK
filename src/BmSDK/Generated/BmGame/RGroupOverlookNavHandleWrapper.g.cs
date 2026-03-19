#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGroupOverlookNavHandleWrapper<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGroupOverlookNavHandleWrapper : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGroupOverlookNavHandleWrapper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGroupOverlookNavHandleWrapper() { }

    /// <summary>
    /// Constructs a new RGroupOverlookNavHandleWrapper
    /// </summary>
    public RGroupOverlookNavHandleWrapper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGroupOverlookNavHandleWrapper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGroupOverlookNavHandleWrapper(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: StoredSearcher
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> StoredSearcher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: APS
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT APS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bInPathSearchStage
    /// </summary>
    public unsafe bool bInPathSearchStage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: PawnSearch
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT PawnSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
