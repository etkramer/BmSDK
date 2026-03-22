#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: InterpTrackAkRTPC<br/>
/// (size = 192)
/// (flags = 134226066)
/// </summary>
public partial class InterpTrackAkRTPC : BmSDK.Engine.InterpTrackFloatBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.InterpTrackAkRTPC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackAkRTPC() { }

    /// <summary>
    /// Constructs a new InterpTrackAkRTPC
    /// </summary>
    public InterpTrackAkRTPC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackAkRTPC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackAkRTPC(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Param
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName Param
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// BoolProperty: GlobalParam
    /// </summary>
    public unsafe bool GlobalParam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 188); }
    }
}
