#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_ChuteToCrawlSpaceDLC<br/>
/// (size = 672)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_ChuteToCrawlSpaceDLC : BmSDK.BmGame.RSpecialMoveConfig_ChuteToCrawlSpace, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_ChuteToCrawlSpaceDLC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_ChuteToCrawlSpaceDLC() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_ChuteToCrawlSpaceDLC
    /// </summary>
    public RSpecialMoveConfig_ChuteToCrawlSpaceDLC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_ChuteToCrawlSpaceDLC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_ChuteToCrawlSpaceDLC(nint ptr) : base(ptr) { }

}
