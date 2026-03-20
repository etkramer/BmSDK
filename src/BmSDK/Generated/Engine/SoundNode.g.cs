#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SoundNode<br/>
/// (size = 104)
/// (flags = 0)
/// </summary>
public partial class SoundNode : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SoundNode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SoundNode() { }

    /// <summary>
    /// Constructs a new SoundNode
    /// </summary>
    public SoundNode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SoundNode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SoundNode(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: NodeUpdateHint
    /// </summary>
    public unsafe int NodeUpdateHint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: ChildNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SoundNode> ChildNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SoundNode>>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
}
