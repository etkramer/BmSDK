#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieModularHud_Disposable<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieModularHud_Disposable : BmSDK.BmGame.RGFxMovieModularHudBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieModularHud_Disposable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieModularHud_Disposable() { }

    /// <summary>
    /// Constructs a new RGFxMovieModularHud_Disposable
    /// </summary>
    public RGFxMovieModularHud_Disposable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieModularHud_Disposable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieModularHud_Disposable(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: MainHud
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieModularHud MainHud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieModularHud>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: RequestsCleanup
    /// </summary>
    public unsafe bool RequestsCleanup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// IntProperty: NumModules
    /// </summary>
    public unsafe int NumModules
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StrProperty: DebugHudName
    /// </summary>
    public unsafe BmSDK.FString DebugHudName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }
}
