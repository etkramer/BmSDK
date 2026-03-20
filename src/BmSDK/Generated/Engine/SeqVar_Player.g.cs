#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqVar_Player<br/>
/// (flags = 0)
/// </summary>
public partial class SeqVar_Player : BmSDK.Engine.SeqVar_Object, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqVar_Player", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqVar_Player() { }

    /// <summary>
    /// Constructs a new SeqVar_Player
    /// </summary>
    public SeqVar_Player(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqVar_Player Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqVar_Player(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Players
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> Players
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bAllPlayers
    /// </summary>
    public unsafe bool bAllPlayers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// IntProperty: PlayerIdx
    /// </summary>
    public unsafe int PlayerIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
}
