#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqVar_Character<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqVar_Character : BmSDK.Engine.SeqVar_Object, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqVar_Character", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqVar_Character() { }

    /// <summary>
    /// Constructs a new SeqVar_Character
    /// </summary>
    public SeqVar_Character(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqVar_Character Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqVar_Character(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: PawnClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
}
