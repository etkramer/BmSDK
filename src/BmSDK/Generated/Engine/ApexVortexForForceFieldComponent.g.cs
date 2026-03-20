#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexVortexForForceFieldComponent<br/>
/// (flags = 0)
/// </summary>
public partial class ApexVortexForForceFieldComponent : BmSDK.Engine.ApexVortexComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexVortexForForceFieldComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexVortexForForceFieldComponent() { }

    /// <summary>
    /// Constructs a new ApexVortexForForceFieldComponent
    /// </summary>
    public ApexVortexForForceFieldComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexVortexForForceFieldComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexVortexForForceFieldComponent(nint ptr) : base(ptr) { }

}
