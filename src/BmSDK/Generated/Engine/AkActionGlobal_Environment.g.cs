#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_Environment<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_Environment : BmSDK.Engine.AkActionGlobal, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_Environment", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_Environment() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_Environment
    /// </summary>
    public AkActionGlobal_Environment(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_Environment Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_Environment(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: EnvironmentSettings
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> EnvironmentSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
