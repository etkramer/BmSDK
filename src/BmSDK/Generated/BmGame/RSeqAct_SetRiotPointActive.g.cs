#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetRiotPointActive<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetRiotPointActive : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetRiotPointActive", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetRiotPointActive() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetRiotPointActive
    /// </summary>
    public RSeqAct_SetRiotPointActive(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetRiotPointActive Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetRiotPointActive(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: InteractPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> InteractPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
