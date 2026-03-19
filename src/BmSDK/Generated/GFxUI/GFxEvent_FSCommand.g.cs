#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.GFxUI;

/// <summary>
/// Class: GFxEvent_FSCommand<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class GFxEvent_FSCommand : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "GFxUI.GFxEvent_FSCommand", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GFxEvent_FSCommand() { }

    /// <summary>
    /// Constructs a new GFxEvent_FSCommand
    /// </summary>
    public GFxEvent_FSCommand(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GFxEvent_FSCommand Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GFxEvent_FSCommand(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Movie
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Movie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ObjectProperty: Handler
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Handler
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// StrProperty: FSCommand
    /// </summary>
    public unsafe BmSDK.FString FSCommand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }
}
