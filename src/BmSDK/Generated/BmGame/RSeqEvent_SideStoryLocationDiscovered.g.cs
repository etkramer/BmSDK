#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_SideStoryLocationDiscovered<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_SideStoryLocationDiscovered : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_SideStoryLocationDiscovered", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_SideStoryLocationDiscovered() { }

    /// <summary>
    /// Constructs a new RSeqEvent_SideStoryLocationDiscovered
    /// </summary>
    public RSeqEvent_SideStoryLocationDiscovered(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_SideStoryLocationDiscovered Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_SideStoryLocationDiscovered(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: IconName
    /// </summary>
    public unsafe BmSDK.FString IconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
}
