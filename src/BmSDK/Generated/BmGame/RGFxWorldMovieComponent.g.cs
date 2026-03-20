#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxWorldMovieComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxWorldMovieComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxWorldMovieComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxWorldMovieComponent() { }

    /// <summary>
    /// Constructs a new RGFxWorldMovieComponent
    /// </summary>
    public RGFxWorldMovieComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxWorldMovieComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxWorldMovieComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ScaleformObject
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxMoviePlayer ScaleformObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxMoviePlayer>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }
}
