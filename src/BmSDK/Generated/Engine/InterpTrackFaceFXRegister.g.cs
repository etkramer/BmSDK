#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackFaceFXRegister<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackFaceFXRegister : BmSDK.Engine.InterpTrackFloatBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackFaceFXRegister", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackFaceFXRegister() { }

    /// <summary>
    /// Constructs a new InterpTrackFaceFXRegister
    /// </summary>
    public InterpTrackFaceFXRegister(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackFaceFXRegister Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackFaceFXRegister(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Register
    /// </summary>
    public unsafe BmSDK.FString Register
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
}
