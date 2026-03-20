#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Scene<br/>
/// (flags = 0)
/// </summary>
public partial class Scene : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Scene", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Scene() { }

    /// <summary>
    /// Constructs a new Scene
    /// </summary>
    public Scene(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Scene Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Scene(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EDetailMode
    /// </summary>
    public enum EDetailMode
    {
        DM_Low = 0,
        DM_Medium = 1,
        DM_High = 2,
        DM_MAX = 3,
    }

    /// <summary>
    /// Enum: ESceneDepthPriorityGroup
    /// </summary>
    public enum ESceneDepthPriorityGroup
    {
        SDPG_UnrealEdBackground = 0,
        SDPG_RockBlimp1 = 1,
        SDPG_RockBlimp2 = 2,
        SDPG_World = 3,
        SDPG_Highlight = 4,
        SDPG_HighlightXray = 5,
        SDPG_MapView = 6,
        SDPG_Foreground = 7,
        SDPG_UnrealEdForeground = 8,
        SDPG_PostProcess = 9,
        SDPG_MAX = 10,
    }
}
