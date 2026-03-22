#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackInstFaceFXRegister<br/>
/// (size = 44)
/// (flags = 134217874)
/// </summary>
public partial class InterpTrackInstFaceFXRegister : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackInstFaceFXRegister", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstFaceFXRegister() { }

    /// <summary>
    /// Constructs a new InterpTrackInstFaceFXRegister
    /// </summary>
    public InterpTrackInstFaceFXRegister(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstFaceFXRegister Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstFaceFXRegister(nint ptr) : base(ptr) { }

}
