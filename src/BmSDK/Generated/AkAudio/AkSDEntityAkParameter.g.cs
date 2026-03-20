#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityAkParameter<br/>
/// (flags = 0)
/// </summary>
public partial class AkSDEntityAkParameter : BmSDK.AkAudio.AkSDEntityValue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityAkParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityAkParameter() { }

    /// <summary>
    /// Constructs a new AkSDEntityAkParameter
    /// </summary>
    public AkSDEntityAkParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityAkParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityAkParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: UseParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName UseParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
}
