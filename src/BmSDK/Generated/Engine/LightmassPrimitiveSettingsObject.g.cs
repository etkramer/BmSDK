#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LightmassPrimitiveSettingsObject<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LightmassPrimitiveSettingsObject : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LightmassPrimitiveSettingsObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LightmassPrimitiveSettingsObject() { }

    /// <summary>
    /// Constructs a new LightmassPrimitiveSettingsObject
    /// </summary>
    public LightmassPrimitiveSettingsObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LightmassPrimitiveSettingsObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LightmassPrimitiveSettingsObject(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: LightmassSettings
    /// </summary>
    public unsafe BmSDK.Engine.EngineTypes.FLightmassPrimitiveSettings LightmassSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.EngineTypes.FLightmassPrimitiveSettings>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
