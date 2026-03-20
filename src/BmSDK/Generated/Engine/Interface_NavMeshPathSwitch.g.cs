#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Interface_NavMeshPathSwitch<br/>
/// (flags = 0)
/// </summary>
public partial class Interface_NavMeshPathSwitch : BmSDK.Engine.Interface_NavMeshPathObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Interface_NavMeshPathSwitch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Interface_NavMeshPathSwitch() { }

    /// <summary>
    /// Constructs a new Interface_NavMeshPathSwitch
    /// </summary>
    public Interface_NavMeshPathSwitch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Interface_NavMeshPathSwitch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Interface_NavMeshPathSwitch(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: AIActivateSwitch
    /// </summary>
    public unsafe bool AIActivateSwitch(BmSDK.Engine.AIController AI)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.Interface_NavMeshPathSwitch.AIActivateSwitch", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AI, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }
}
