#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkGroupContext_Combat<br/>
/// (flags = 0)
/// </summary>
public partial class RBarkGroupContext_Combat : BmSDK.BmGame.RBarkGroupContext, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkGroupContext_Combat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkGroupContext_Combat() { }

    /// <summary>
    /// Constructs a new RBarkGroupContext_Combat
    /// </summary>
    public RBarkGroupContext_Combat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkGroupContext_Combat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkGroupContext_Combat(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetDlgComponentsOfGroup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogueComponent> GetDlgComponentsOfGroup()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkGroupContext_Combat.GetDlgComponentsOfGroup", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogueComponent>>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
