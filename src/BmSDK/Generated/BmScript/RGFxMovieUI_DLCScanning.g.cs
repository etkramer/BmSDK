#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_DLCScanning<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_DLCScanning : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_DLCScanning", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_DLCScanning() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_DLCScanning
    /// </summary>
    public RGFxMovieUI_DLCScanning(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_DLCScanning Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_DLCScanning(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DLCEnum
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DLCEnum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: RDLCMan
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RDLCMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// BoolProperty: bScanDone
    /// </summary>
    public unsafe bool bScanDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: Counter
    /// </summary>
    public unsafe int Counter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

}
