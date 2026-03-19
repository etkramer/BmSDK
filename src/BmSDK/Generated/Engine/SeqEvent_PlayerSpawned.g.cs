#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqEvent_PlayerSpawned<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqEvent_PlayerSpawned : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqEvent_PlayerSpawned", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqEvent_PlayerSpawned() { }

    /// <summary>
    /// Constructs a new SeqEvent_PlayerSpawned
    /// </summary>
    public SeqEvent_PlayerSpawned(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqEvent_PlayerSpawned Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqEvent_PlayerSpawned(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SpawnPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
}
