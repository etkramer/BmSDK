#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RInteractionComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RInteractionComponent : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RInteractionComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInteractionComponent() { }

    /// <summary>
    /// Constructs a new RInteractionComponent
    /// </summary>
    public RInteractionComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInteractionComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInteractionComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: RelevantInteractionClasses
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RelevantInteractionClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: InteractionClassPointer
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> InteractionClassPointer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: MaxDistOfTargetPointFromOrigin
    /// </summary>
    public unsafe float MaxDistOfTargetPointFromOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
