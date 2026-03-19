#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCharacterBioCue<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCharacterBioCue : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCharacterBioCue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacterBioCue() { }

    /// <summary>
    /// Constructs a new RCharacterBioCue
    /// </summary>
    public RCharacterBioCue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacterBioCue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacterBioCue(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Speech
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Speech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ClassProperty: WeaponType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: ForceRandomLine
    /// </summary>
    public unsafe int ForceRandomLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: Barksets
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> Barksets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: AnimsetReferences
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT AnimsetReferences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
}
