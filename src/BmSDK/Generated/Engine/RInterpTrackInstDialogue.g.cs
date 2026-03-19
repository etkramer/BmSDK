#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RInterpTrackInstDialogue<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RInterpTrackInstDialogue : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RInterpTrackInstDialogue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInterpTrackInstDialogue() { }

    /// <summary>
    /// Constructs a new RInterpTrackInstDialogue
    /// </summary>
    public RInterpTrackInstDialogue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInterpTrackInstDialogue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInterpTrackInstDialogue(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: LastUpdatePosition
    /// </summary>
    public unsafe float LastUpdatePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: SeekPos
    /// </summary>
    public unsafe float SeekPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ObjectProperty: LastDialogue
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: SpeechIDs
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SpeechIDs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
