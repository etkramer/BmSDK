#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqVar_NamedPawn<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqVar_NamedPawn : BmSDK.Engine.SeqVar_Object, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqVar_NamedPawn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqVar_NamedPawn() { }

    /// <summary>
    /// Constructs a new RSeqVar_NamedPawn
    /// </summary>
    public RSeqVar_NamedPawn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqVar_NamedPawn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqVar_NamedPawn(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: PawnReferenceName
    /// </summary>
    public unsafe BmSDK.FName PawnReferenceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
}
