#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqVar_SpecificPlayerChar<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqVar_SpecificPlayerChar : BmSDK.Engine.SeqVar_Object, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqVar_SpecificPlayerChar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqVar_SpecificPlayerChar() { }

    /// <summary>
    /// Constructs a new RSeqVar_SpecificPlayerChar
    /// </summary>
    public RSeqVar_SpecificPlayerChar(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqVar_SpecificPlayerChar Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqVar_SpecificPlayerChar(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: Player
    /// </summary>
    public unsafe byte Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: AutoSpawnBatmobileForCapture
    /// </summary>
    public unsafe bool AutoSpawnBatmobileForCapture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }
}
