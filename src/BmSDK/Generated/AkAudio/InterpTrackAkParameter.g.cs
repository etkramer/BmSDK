#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: InterpTrackAkParameter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackAkParameter : BmSDK.Engine.InterpTrackFloatBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.InterpTrackAkParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackAkParameter() { }

    /// <summary>
    /// Constructs a new InterpTrackAkParameter
    /// </summary>
    public InterpTrackAkParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackAkParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackAkParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Parameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Parameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: IsGlobalParameter
    /// </summary>
    public unsafe bool IsGlobalParameter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }
}
