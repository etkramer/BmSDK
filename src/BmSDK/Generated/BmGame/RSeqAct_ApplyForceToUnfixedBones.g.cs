#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ApplyForceToUnfixedBones<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ApplyForceToUnfixedBones : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ApplyForceToUnfixedBones", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ApplyForceToUnfixedBones() { }

    /// <summary>
    /// Constructs a new RSeqAct_ApplyForceToUnfixedBones
    /// </summary>
    public RSeqAct_ApplyForceToUnfixedBones(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ApplyForceToUnfixedBones Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ApplyForceToUnfixedBones(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: NPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn NPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ArrayProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BoneNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: ForceVectors
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> ForceVectors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
