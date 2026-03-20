#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_SetGauntletPortraitName<br/>
/// (size = 100)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_SetGauntletPortraitName : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_SetGauntletPortraitName", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_SetGauntletPortraitName() { }

    /// <summary>
    /// Constructs a new RAnimNotify_SetGauntletPortraitName
    /// </summary>
    public RAnimNotify_SetGauntletPortraitName(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_SetGauntletPortraitName Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_SetGauntletPortraitName(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: PortraitName
    /// </summary>
    public unsafe BmSDK.FString PortraitName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
