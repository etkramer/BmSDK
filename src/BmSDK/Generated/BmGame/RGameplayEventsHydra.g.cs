#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameplayEventsHydra<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGameplayEventsHydra : BmSDK.Engine.GameplayEventsWriter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameplayEventsHydra", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGameplayEventsHydra() { }

    /// <summary>
    /// Constructs a new RGameplayEventsHydra
    /// </summary>
    public RGameplayEventsHydra(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGameplayEventsHydra Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameplayEventsHydra(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: MapName
    /// </summary>
    public unsafe BmSDK.FString MapName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ArrayProperty: GameActionNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> GameActionNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ArrayProperty: EnabledGameActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EnabledGameActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// FloatProperty: HydraUpdateTime
    /// </summary>
    public unsafe float HydraUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }
}
