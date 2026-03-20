#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDataProvider_PlayerAchievements<br/>
/// (flags = 0)
/// </summary>
public partial class UIDataProvider_PlayerAchievements : BmSDK.Engine.UIDataProvider_OnlinePlayerDataBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataProvider_PlayerAchievements", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIDataProvider_PlayerAchievements() { }

    /// <summary>
    /// Constructs a new UIDataProvider_PlayerAchievements
    /// </summary>
    public UIDataProvider_PlayerAchievements(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDataProvider_PlayerAchievements Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataProvider_PlayerAchievements(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Achievements
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FAchievementDetails> Achievements
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FAchievementDetails>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
