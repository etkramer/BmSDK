#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetAICollision<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetAICollision : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetAICollision", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetAICollision() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetAICollision
    /// </summary>
    public RSeqAct_SetAICollision(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetAICollision Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetAICollision(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: PawnList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> PawnList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ByteProperty: PhysWalkingType
    /// </summary>
    public unsafe byte PhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ByteProperty: RagdollVsNavMeshSolution
    /// </summary>
    public unsafe byte RagdollVsNavMeshSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 369); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 369); }
    }
}
