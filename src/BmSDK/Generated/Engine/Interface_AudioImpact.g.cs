#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Interface_AudioImpact<br/>
/// (flags = 0)
/// </summary>
public partial class Interface_AudioImpact : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Interface_AudioImpact", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Interface_AudioImpact() { }

    /// <summary>
    /// Constructs a new Interface_AudioImpact
    /// </summary>
    public Interface_AudioImpact(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Interface_AudioImpact Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Interface_AudioImpact(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetImpactAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GetImpactAudioEvent(BmSDK.Engine.AkWwise.EAkWorldMaterial Mat)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.Interface_AudioImpact.GetImpactAudioEvent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }
}
