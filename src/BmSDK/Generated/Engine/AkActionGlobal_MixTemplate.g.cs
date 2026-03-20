#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_MixTemplate<br/>
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_MixTemplate : BmSDK.Engine.AkActionGlobal, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_MixTemplate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_MixTemplate() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_MixTemplate
    /// </summary>
    public AkActionGlobal_MixTemplate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_MixTemplate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_MixTemplate(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: MixTemplate
    /// </summary>
    public unsafe BmSDK.Engine.AkMixTemplate MixTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkMixTemplate>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
