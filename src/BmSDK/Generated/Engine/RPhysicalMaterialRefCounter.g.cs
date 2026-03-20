#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RPhysicalMaterialRefCounter<br/>
/// (size = 84)
/// (flags = 33554450)
/// </summary>
public partial class RPhysicalMaterialRefCounter : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RPhysicalMaterialRefCounter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPhysicalMaterialRefCounter() { }

    /// <summary>
    /// Constructs a new RPhysicalMaterialRefCounter
    /// </summary>
    public RPhysicalMaterialRefCounter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPhysicalMaterialRefCounter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPhysicalMaterialRefCounter(nint ptr) : base(ptr) { }

}
