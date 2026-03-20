#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAIBrain_Hostage<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAIBrain_Hostage : BmSDK.BmGame.RAIBrain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAIBrain_Hostage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAIBrain_Hostage() { }

    /// <summary>
    /// Constructs a new RAIBrain_Hostage
    /// </summary>
    public RAIBrain_Hostage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAIBrain_Hostage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAIBrain_Hostage(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: EscapeType
    /// </summary>
    public unsafe BmSDK.BmGame.RAIBrain_Hostage.PlayerSeenEscapeTypeEnum EscapeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAIBrain_Hostage.PlayerSeenEscapeTypeEnum>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// BoolProperty: bEscaped
    /// </summary>
    public unsafe bool bEscaped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bEndOfWave
    /// </summary>
    public unsafe bool bEndOfWave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// Enum: PlayerSeenEscapeTypeEnum
    /// </summary>
    public enum PlayerSeenEscapeTypeEnum
    {
        PSE_None = 0,
        PSE_Left = 1,
        PSE_Right = 2,
        PSE_MAX = 3,
    }
}
