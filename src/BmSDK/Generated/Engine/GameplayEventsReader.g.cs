#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameplayEventsReader<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class GameplayEventsReader : BmSDK.Engine.GameplayEvents, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameplayEventsReader", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GameplayEventsReader() { }

    /// <summary>
    /// Constructs a new GameplayEventsReader
    /// </summary>
    public GameplayEventsReader(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameplayEventsReader Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameplayEventsReader(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: RegisteredHandlers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RegisteredHandlers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }
}
