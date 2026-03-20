#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: HelpCommandlet<br/>
/// (flags = 0)
/// </summary>
public partial class HelpCommandlet : BmSDK.Commandlet, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.HelpCommandlet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal HelpCommandlet() { }

    /// <summary>
    /// Constructs a new HelpCommandlet
    /// </summary>
    public HelpCommandlet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, HelpCommandlet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected HelpCommandlet(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Main
    /// </summary>
    public unsafe int Main(BmSDK.FString Params)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Core.HelpCommandlet.Main", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }
}
