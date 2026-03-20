#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RInteractionClass<br/>
/// (flags = 0)
/// </summary>
public partial class RInteractionClass : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RInteractionClass", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInteractionClass() { }

    /// <summary>
    /// Constructs a new RInteractionClass
    /// </summary>
    public RInteractionClass(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInteractionClass Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInteractionClass(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ActorList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RInteractionComponent> ActorList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RInteractionComponent>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
