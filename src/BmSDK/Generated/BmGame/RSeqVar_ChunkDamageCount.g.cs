#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqVar_ChunkDamageCount<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqVar_ChunkDamageCount : BmSDK.Engine.SeqVar_Int, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqVar_ChunkDamageCount", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqVar_ChunkDamageCount() { }

    /// <summary>
    /// Constructs a new RSeqVar_ChunkDamageCount
    /// </summary>
    public RSeqVar_ChunkDamageCount(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqVar_ChunkDamageCount Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqVar_ChunkDamageCount(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: IntValue
    /// </summary>
    public unsafe int IntValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
}
