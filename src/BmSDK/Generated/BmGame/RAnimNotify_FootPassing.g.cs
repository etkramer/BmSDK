#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_FootPassing<br/>
/// (size = 85)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_FootPassing : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_FootPassing", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_FootPassing() { }

    /// <summary>
    /// Constructs a new RAnimNotify_FootPassing
    /// </summary>
    public RAnimNotify_FootPassing(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_FootPassing Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_FootPassing(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: Passing
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_FootPassing.EFootPassing Passing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_FootPassing.EFootPassing>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// Enum: EFootPassing
    /// </summary>
    public enum EFootPassing
    {
        FOOTPASSING_Left = 0,
        FOOTPASSING_Right = 1,
        FOOTPASSING_MAX = 2,
    }
}
