#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameplayEventsWriter<br/>
/// (flags = 0)
/// </summary>
public partial class GameplayEventsWriter : BmSDK.Engine.GameplayEventsWriterBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameplayEventsWriter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GameplayEventsWriter() { }

    /// <summary>
    /// Constructs a new GameplayEventsWriter
    /// </summary>
    public GameplayEventsWriter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameplayEventsWriter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameplayEventsWriter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Game
    /// </summary>
    public unsafe BmSDK.Engine.GameInfo Game
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameInfo>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

}
