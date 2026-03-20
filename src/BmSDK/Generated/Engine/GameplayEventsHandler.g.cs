#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameplayEventsHandler<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class GameplayEventsHandler : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameplayEventsHandler", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GameplayEventsHandler() { }

    /// <summary>
    /// Constructs a new GameplayEventsHandler
    /// </summary>
    public GameplayEventsHandler(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameplayEventsHandler Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameplayEventsHandler(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: EventIDFilter
    /// </summary>
    public unsafe BmSDK.TArray<int> EventIDFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: GroupFilter
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameplayEvents.FGameStatGroup> GroupFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameplayEvents.FGameStatGroup>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: Reader
    /// </summary>
    public unsafe BmSDK.Engine.GameplayEventsReader Reader
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameplayEventsReader>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
}
