#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_SetRigidBodyIgnoreVehicles<br/>
/// (flags = 0)
/// </summary>
public partial class SeqAct_SetRigidBodyIgnoreVehicles : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_SetRigidBodyIgnoreVehicles", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_SetRigidBodyIgnoreVehicles() { }

    /// <summary>
    /// Constructs a new SeqAct_SetRigidBodyIgnoreVehicles
    /// </summary>
    public SeqAct_SetRigidBodyIgnoreVehicles(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_SetRigidBodyIgnoreVehicles Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_SetRigidBodyIgnoreVehicles(nint ptr) : base(ptr) { }

}
