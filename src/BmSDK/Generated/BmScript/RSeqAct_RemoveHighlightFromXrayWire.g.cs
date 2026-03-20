#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_RemoveHighlightFromXrayWire<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_RemoveHighlightFromXrayWire : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_RemoveHighlightFromXrayWire", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_RemoveHighlightFromXrayWire() { }

    /// <summary>
    /// Constructs a new RSeqAct_RemoveHighlightFromXrayWire
    /// </summary>
    public RSeqAct_RemoveHighlightFromXrayWire(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_RemoveHighlightFromXrayWire Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_RemoveHighlightFromXrayWire(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: xrayActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RXrayInterpActor> xrayActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RXrayInterpActor>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
