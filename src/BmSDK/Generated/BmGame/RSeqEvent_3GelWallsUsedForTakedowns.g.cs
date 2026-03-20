#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_3GelWallsUsedForTakedowns<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_3GelWallsUsedForTakedowns : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_3GelWallsUsedForTakedowns", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_3GelWallsUsedForTakedowns() { }

    /// <summary>
    /// Constructs a new RSeqEvent_3GelWallsUsedForTakedowns
    /// </summary>
    public RSeqEvent_3GelWallsUsedForTakedowns(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_3GelWallsUsedForTakedowns Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_3GelWallsUsedForTakedowns(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: wallsUsedForTakedowns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> wallsUsedForTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
}
