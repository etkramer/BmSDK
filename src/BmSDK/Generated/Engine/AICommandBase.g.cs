#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: AICommandBase<br/>
/// (size = 48)
/// (flags = 134217875)
/// </summary>
public partial class AICommandBase : BmSDK.StateObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AICommandBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AICommandBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AICommandBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetUtility
    /// </summary>
    public unsafe static int GetUtility(BmSDK.Engine.AIController InAI)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AICommandBase.GetUtility", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }
}
