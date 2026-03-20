#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Level<br/>
/// (flags = 0)
/// </summary>
public partial class Level : BmSDK.Engine.LevelBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Level", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Level() { }

    /// <summary>
    /// Constructs a new Level
    /// </summary>
    public Level(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Level Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Level(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ShadowmapTotalSize
    /// </summary>
    public unsafe float ShadowmapTotalSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// FloatProperty: LightmapTotalSize
    /// </summary>
    public unsafe float LightmapTotalSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }
}
