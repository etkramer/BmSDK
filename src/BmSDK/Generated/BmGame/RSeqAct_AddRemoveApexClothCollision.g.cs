#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_AddRemoveApexClothCollision<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_AddRemoveApexClothCollision : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_AddRemoveApexClothCollision", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_AddRemoveApexClothCollision() { }

    /// <summary>
    /// Constructs a new RSeqAct_AddRemoveApexClothCollision
    /// </summary>
    public RSeqAct_AddRemoveApexClothCollision(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_AddRemoveApexClothCollision Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_AddRemoveApexClothCollision(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ClothBlockingVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RApexClothBlockingVolume> ClothBlockingVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RApexClothBlockingVolume>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ArrayProperty: PawnsAndCinematicActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> PawnsAndCinematicActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
}
