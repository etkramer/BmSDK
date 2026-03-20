#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LevelStreamingAlwaysLoaded<br/>
/// (size = 288)
/// (flags = 134221970)
/// </summary>
public partial class LevelStreamingAlwaysLoaded : BmSDK.Engine.LevelStreaming, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LevelStreamingAlwaysLoaded", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LevelStreamingAlwaysLoaded() { }

    /// <summary>
    /// Constructs a new LevelStreamingAlwaysLoaded
    /// </summary>
    public LevelStreamingAlwaysLoaded(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LevelStreamingAlwaysLoaded Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LevelStreamingAlwaysLoaded(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bIsProceduralBuildingLODLevel
    /// </summary>
    public unsafe bool bIsProceduralBuildingLODLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }
}
