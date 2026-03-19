#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_Robot<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCharacter_Robot : BmSDK.BmGame.RCharacter_Thug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_Robot", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_Robot() { }

    /// <summary>
    /// Constructs a new RCharacter_Robot
    /// </summary>
    public RCharacter_Robot(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_Robot Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_Robot(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: CanOnlyBeHitBy
    /// </summary>
    public unsafe BmSDK.FName CanOnlyBeHitBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
}
