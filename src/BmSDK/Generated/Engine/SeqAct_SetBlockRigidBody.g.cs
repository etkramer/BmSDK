#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_SetBlockRigidBody<br/>
/// (size = 204)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_SetBlockRigidBody : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_SetBlockRigidBody", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_SetBlockRigidBody() { }

    /// <summary>
    /// Constructs a new SeqAct_SetBlockRigidBody
    /// </summary>
    public SeqAct_SetBlockRigidBody(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_SetBlockRigidBody Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_SetBlockRigidBody(nint ptr) : base(ptr) { }

}
