#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkGroupContext<br/>
/// (size = 84)
/// (flags = 134217874)
/// </summary>
public partial class RBarkGroupContext : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkGroupContext", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkGroupContext() { }

    /// <summary>
    /// Constructs a new RBarkGroupContext
    /// </summary>
    public RBarkGroupContext(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkGroupContext Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkGroupContext(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetDlgComponentsOfGroup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogueComponent> GetDlgComponentsOfGroup()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkGroupContext.GetDlgComponentsOfGroup", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogueComponent>>(paramsPtr + 0);
    }
}
