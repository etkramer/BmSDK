#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkGroupContext_Pred<br/>
/// (size = 92)
/// (flags = 0)
/// </summary>
public partial class RBarkGroupContext_Pred : BmSDK.BmGame.RBarkGroupContext, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkGroupContext_Pred", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkGroupContext_Pred() { }

    /// <summary>
    /// Constructs a new RBarkGroupContext_Pred
    /// </summary>
    public RBarkGroupContext_Pred(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkGroupContext_Pred Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkGroupContext_Pred(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetDlgComponentsOfGroup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogueComponent> GetDlgComponentsOfGroup()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkGroupContext_Pred.GetDlgComponentsOfGroup", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogueComponent>>(paramsPtr + 0);
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
