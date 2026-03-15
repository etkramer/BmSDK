#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkDrawSoundBoxComponent<br/>
/// (size = 432)
/// (flags = 2290102418)
/// </summary>
public partial class AkDrawSoundBoxComponent : BmSDK.Engine.DrawBoxComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkDrawSoundBoxComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkDrawSoundBoxComponent() { }

    /// <summary>
    /// Constructs a new AkDrawSoundBoxComponent
    /// </summary>
    public AkDrawSoundBoxComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkDrawSoundBoxComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkDrawSoundBoxComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: DrawScale
    /// </summary>
    public unsafe float DrawScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }
}
