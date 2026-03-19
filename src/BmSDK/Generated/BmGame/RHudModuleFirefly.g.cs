#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleFirefly<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHudModuleFirefly : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleFirefly", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleFirefly() { }

    /// <summary>
    /// Constructs a new RHudModuleFirefly
    /// </summary>
    public RHudModuleFirefly(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleFirefly Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleFirefly(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: CachedFunction_SetHealthBar
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetHealthBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_TurnOffHealthBar
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_TurnOffHealthBar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: CurrentHealthProportion
    /// </summary>
    public unsafe float CurrentHealthProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }
}
