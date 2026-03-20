#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqVar_SideStoriesDisabledReason<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqVar_SideStoriesDisabledReason : BmSDK.Engine.SeqVar_String, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqVar_SideStoriesDisabledReason", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqVar_SideStoriesDisabledReason() { }

    /// <summary>
    /// Constructs a new RSeqVar_SideStoriesDisabledReason
    /// </summary>
    public RSeqVar_SideStoriesDisabledReason(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqVar_SideStoriesDisabledReason Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqVar_SideStoriesDisabledReason(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: StrValue
    /// </summary>
    public unsafe BmSDK.FString StrValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
}
