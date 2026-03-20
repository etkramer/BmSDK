#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Interface_Speaker<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class Interface_Speaker : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Interface_Speaker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Interface_Speaker() { }

    /// <summary>
    /// Constructs a new Interface_Speaker
    /// </summary>
    public Interface_Speaker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Interface_Speaker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Interface_Speaker(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Speak
    /// </summary>
    public unsafe void Speak(BmSDK.Engine.SoundCue Cue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.Interface_Speaker.Speak", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
