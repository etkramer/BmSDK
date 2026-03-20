#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_BotUseFilmDoor<br/>
/// (size = 480)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_BotUseFilmDoor : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_BotUseFilmDoor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_BotUseFilmDoor() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_BotUseFilmDoor
    /// </summary>
    public RSpecialMoveConfig_BotUseFilmDoor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_BotUseFilmDoor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_BotUseFilmDoor(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: RobinElvisAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RobinElvisAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: RobinCopAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RobinCopAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: RobinWomanAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RobinWomanAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }
}
